using System;
using System.Linq;
using VendingMachineLLD.Enums;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD.Service.Implementation.States
{
    public class Selection : IState
    {
        public void Cancel(IVendingMachine vendingMachine)
        {
            Console.WriteLine("Cancelling process");
            if (vendingMachine.Coins.Count > 0)
            {
                Console.WriteLine("Initiating refund");
                this.Refund(vendingMachine);
            }

            vendingMachine.State = new Idle();
        }

        public void ChoseProduct(IVendingMachine vendingMachine)
        {
            vendingMachine.Inventory.ShowInventory();

            Console.Write("Enter the item code: ");
            int code = Convert.ToInt32(Console.ReadLine());

            while (!vendingMachine.Inventory.HasItem(code))
            {
                Console.WriteLine("Item not found or not in stock");
                Console.Write("Enter the item code: ");
                code = Convert.ToInt32(Console.ReadLine());
            }
            vendingMachine.ChosenProductCode = code;


            double money = 0;
            foreach (var coin in vendingMachine.Coins)
                money += (int)coin;

            double balance = vendingMachine.Inventory.PriceDifference(code, money);

            if (balance > 0)
            {
                this.ReturnChange(vendingMachine);
            }
            if (balance < 0)
            {
                Console.WriteLine($"Insufficient money, please insert required money: {balance}");
                vendingMachine.State = new HasMoney();
                return;
            }

            vendingMachine.Inventory.ItemBought(code);

            vendingMachine.State = new Dispense();
        }

        public void DispenseProduct(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(IVendingMachine vendingMachine, Coins coin)
        {
            throw new NotImplementedException();
        }

        public void PressChooseProduct(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void Refund(IVendingMachine vendingMachine)
        {
            Console.WriteLine("Refund Initiated");
            int totalRefund = 0;
            foreach (var coin in vendingMachine.Coins)
            {
                totalRefund += (int)coin;
            }

            vendingMachine.Coins.Clear();
            Console.WriteLine($"Amount:{totalRefund} refunded");
        }

        public void ReturnChange(IVendingMachine vendingMachine)
        {
            double money = 0;
            foreach (var coin in vendingMachine.Coins)
                money += (int)coin;

            double balance = vendingMachine.Inventory.PriceDifference(vendingMachine.ChosenProductCode, money);
            while (balance > 0)
            {
                while (balance >= (double)Coins.Quater)
                {
                    Coins c = vendingMachine.Coins.FirstOrDefault(c => c.Equals(Coins.Quater));
                    if (c != 0) vendingMachine.Coins.Remove(c);
                    balance -= (double)Coins.Quater;
                    Console.WriteLine("Collect a Quater from coins tray");
                }
                while (balance >= (double)Coins.Dime)
                {
                    Coins c = vendingMachine.Coins.FirstOrDefault(c => c.Equals(Coins.Dime));
                    if (c != 0) vendingMachine.Coins.Remove(c);
                    balance -= (double)Coins.Dime;
                    Console.WriteLine("Collect a Dime from coins tray");
                }
                while (balance >= (double)Coins.Nickel)
                {
                    Coins c = vendingMachine.Coins.FirstOrDefault(c => c.Equals(Coins.Nickel));
                    if (c != 0) vendingMachine.Coins.Remove(c);
                    balance -= (double)Coins.Nickel;
                    Console.WriteLine("Collect a Nickel from coins tray");
                }
                while (balance >= (double)Coins.Peny)
                {
                    Coins c = vendingMachine.Coins.FirstOrDefault(c => c.Equals(Coins.Peny));
                    if (c != 0) vendingMachine.Coins.Remove(c);
                    balance -= (double)Coins.Peny;
                    Console.WriteLine("Collect a Peny from coins tray");
                }
            }

            Console.WriteLine("Return change processsed");
        }

        public void Start(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }
}

