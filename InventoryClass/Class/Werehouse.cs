using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Class
{
    internal class Werehouse
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string Direction { get; set; }

        public List<Item> StoreItems { get; set; }

        public int CapacityInKg { get; set; }

        public int AcutalCapacity { get; set; }

        public void RemoveItem(Item item)
        {
           
        }
        public void AddItem(Item item) 
        {
            
        }
        public void AddItemStock (Item item, int amount)
        {

        }
        public void RemoveItemStock(Item item, int amount )
        {

        }
    }
}
