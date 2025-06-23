using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    public class GroceryItem
    {
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public double TotalPrice => Quantity * UnitPrice;

    }
}
