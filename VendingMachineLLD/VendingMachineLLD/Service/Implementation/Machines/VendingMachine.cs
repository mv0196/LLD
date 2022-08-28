using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineLLD.Entities;
using VendingMachineLLD.Enums;
using VendingMachineLLD.Service.Implementation.States;
using VendingMachineLLD.Service.Interface;

namespace VendingMachineLLD.Service.Implementation.Machines
{
    public class VendingMachine : IVendingMachine
    {
        public Inventory Inventory { get ; set; }
        public List<Coins> Coins { get; set; }
        public IState State { get; set; }
        public int ChosenProductCode { get; set;}

        public VendingMachine()
        {
            Inventory = new Inventory();
            PopulateInventory();

            Coins = new List<Coins>();
            State = new Idle();

        }

        private void PopulateInventory()
        {
            Inventory.AddItemShelf(new ItemShelf(700, ItemType.Juice, 12, 2));
            Inventory.AddItemShelf(new ItemShelf(701, ItemType.Coke, 10, 4));
            Inventory.AddItemShelf(new ItemShelf(702, ItemType.Pepsi, 11, 7));
            Inventory.AddItemShelf(new ItemShelf(703, ItemType.Water, 8, 5));
            Inventory.AddItemShelf(new ItemShelf(704, ItemType.Frooti, 13, 6));
            Inventory.AddItemShelf(new ItemShelf(705, ItemType.Limca, 15, 4));
        }
    }
}
