using System;
using System.Collections.Generic;
using System.Linq;

namespace VendingMachineLLD.Entities
{
    public class Inventory
    {
        private readonly List<ItemShelf> itemShelves;
        public Inventory()
        {
            itemShelves = new List<ItemShelf>();
        }

        public Inventory(List<ItemShelf> itemShelves)
        {
            this.itemShelves = itemShelves;
        }

        public void AddItemShelf(ItemShelf itemShelf)
        {
            this.itemShelves.Add(itemShelf);
        }

        public void ShowInventory()
        {
            Console.WriteLine("===================================================================");
            int i = 0;
            foreach (var itemShelf in itemShelves)
            {
                Console.Write($"\t\t{itemShelf.Item.Type} - {itemShelf.Code}");
                i++;
                
                if (i % 3 == 0)
                    Console.WriteLine();
                
            }
            Console.WriteLine("===================================================================");
        }
        public bool HasItem(int code)
        {
            ItemShelf itemShelf = itemShelves.FirstOrDefault(i => i.Code == code);
            if (itemShelf == null || itemShelf.Quantity == 0) return false;
            return true;
        }

        public double PriceDifference(int code, double money)
        {
            ItemShelf itemShelf = itemShelves.FirstOrDefault(i => i.Code == code);
            if (itemShelf == null) throw new Exception($"Item: {code} not found");
            if (itemShelf.Quantity == 0) throw new Exception($"Item: {code} is not in stock");

            return money - itemShelf.Item.Price;
        }
        public void ItemBought(int code)
        {
            ItemShelf itemShelf = itemShelves.FirstOrDefault(i => i.Code == code);
            if (itemShelf == null) throw new Exception($"Item: {code} not found");
            if (itemShelf.Quantity == 0) throw new Exception($"Item: {code} is not in stock");

            itemShelf.Quantity--;
        }

        public void ItemRestocked(int code, int quantity)
        {
            if (quantity <= 0) throw new Exception("Invalid Quantity");

            ItemShelf itemShelf = itemShelves.FirstOrDefault(i => i.Code == code);
            if (itemShelf == null) throw new Exception($"Item: {code} not found");
            if (itemShelf.Quantity == 0) throw new Exception($"Item: {code} is not in stock");

            itemShelf.Quantity += quantity;
        }
    }
}
