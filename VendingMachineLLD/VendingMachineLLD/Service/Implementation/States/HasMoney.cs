using System;
using VendingMachineLLD.Enums;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD.Service.Implementation.States
{
    public class HasMoney : IState
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
            throw new NotImplementedException();
        }

        public void DispenseProduct(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void InsertCoin(IVendingMachine vendingMachine, Coins coin)
        {
            vendingMachine.Coins.Add(coin);
        }

        public void PressChooseProduct(IVendingMachine vendingMachine)
        {
            vendingMachine.State = new Selection();
        }

        public void Refund(IVendingMachine vendingMachine)
        {
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
            throw new NotImplementedException();
        }

        public void Start(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }
    }
}

