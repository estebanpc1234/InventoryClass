using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Class
{
    internal class Item
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public int Stock { get; set; }

        public double Price { get; set; }

        public double IndividualWeight { get; set; }

        public double TotalWeight { get; set; }

        public string IndividualDimesions { get; set; }
    }
}
