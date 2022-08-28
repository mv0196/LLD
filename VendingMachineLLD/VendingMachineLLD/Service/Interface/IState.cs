using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineLLD.Enums;

namespace VendingMachineLLD.Service.Interface
{
    public interface IState
    {
        void Start(IVendingMachine vendingMachine);
        void InsertCoin(IVendingMachine vendingMachine, Coins coin);
        void Cancel(IVendingMachine vendingMachine);
        void Refund(IVendingMachine vendingMachine);
        void PressChooseProduct(IVendingMachine vendingMachine);
        void ChoseProduct(IVendingMachine vendingMachine);
        void ReturnChange(IVendingMachine vendingMachine);
        void DispenseProduct(IVendingMachine vendingMachine);
    }
}
