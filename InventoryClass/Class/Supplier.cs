using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Class
{
    internal class Supplier
    {
        public int id { get; set; }
        public string Name { get; set; }

        public string number { get; set; }

        public string email { get; set; }

        public string Direction { get; set; }

        public List<Item> SuppliedItems { get; set; }

        public TransportOrder RemainingOrders { get; set; }
    }
}
