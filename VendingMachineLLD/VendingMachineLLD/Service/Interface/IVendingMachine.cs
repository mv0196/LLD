using System.Collections.Generic;
using VendingMachineLLD.Entities;
using VendingMachineLLD.Enums;

namespace VendingMachineLLD.Service.Interface
{
    public interface IVendingMachine
    {
        Inventory Inventory { get; set; }
        List<Coins> Coins { get; set; }
        IState State { get; set; }
        int ChosenProductCode { get; set; }
    }
}
