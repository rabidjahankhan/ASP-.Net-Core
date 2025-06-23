using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GroceryVoucher voucher = new GroceryVoucher(@"C:\Users\USER\source\repos\OOP_SOLID_Principles\Practice3\groceryitems.csv");
            voucher.ProcessItems();
        }
    }
}
