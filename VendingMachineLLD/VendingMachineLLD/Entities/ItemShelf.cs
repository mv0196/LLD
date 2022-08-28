using VendingMachineLLD.Enums;

namespace VendingMachineLLD.Entities
{
    public class ItemShelf
    {
        public int Code { get; set; }
        public int Quantity { get; set; }
        public Item Item { get; set; }

        public ItemShelf(int code, ItemType type, double price, int quantity)
        {
            Code = code;
            Quantity = quantity;
            Item = new Item(type, price);
        }
    }
}
