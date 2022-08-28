using System;
using VendingMachineLLD.Enums;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD.Service.Implementation.States
{
    public class Dispense : IState
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
            Console.WriteLine("Item dispenced, please collect from the dispense tray");
            vendingMachine.State = new Idle();
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
            throw new NotImplementedException();
        }
    }
}

