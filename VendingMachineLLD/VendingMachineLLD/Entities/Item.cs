using System.Text;
using System.Threading.Tasks;
using VendingMachineLLD.Enums;

namespace VendingMachineLLD.Entities
{
    public class Item
    {
        public ItemType Type { get; set; }
        public double Price { get; set; }

        public Item(ItemType type, double price)
        {
            Type = type;
            Price = price;
        }
    }
}
