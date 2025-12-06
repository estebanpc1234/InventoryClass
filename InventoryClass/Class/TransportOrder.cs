using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Class
{
    internal class TransportOrder
    {
        public int Id { get; set; }

        public Werehouse Leave { get; set; }

        public Werehouse Arrival { get; set; }

        public Supplier Supplier { get; set; }
       

        public List<Item> Items { get; set; }

        public double TotalWeight { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public bool IsActive { get; set; }


    }
}
