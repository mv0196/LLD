using System;
using VendingMachineLLD.Enums;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD.Service.Implementation.States
{
    public class Idle : IState
    {
        public void Cancel(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void PressChooseProduct(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void Refund(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void ReturnChange(IVendingMachine vendingMachine)
        {
            throw new NotImplementedException();
        }

        public void Start(IVendingMachine vendingMachine)
        {
            Console.WriteLine("Starting Process");
            vendingMachine.Coins.Clear();
            vendingMachine.ChosenProductCode = -1;

            vendingMachine.State = new HasMoney();
        }
    }
}

