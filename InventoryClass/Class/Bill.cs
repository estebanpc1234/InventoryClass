using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClass.Class
{
    internal class Bill
    {   
        public int BillId { get; set; }

        public string IssuerName { get; set; }

        public string Direction { get; set; }

        public DateTime Date { get; set; }  

        public List<Item> Items { get; set; }

        public double Total {  get; set; }

    }
}
