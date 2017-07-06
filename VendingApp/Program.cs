using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            Item crisps = new Item(40, "Crisps");
            Item water = new Item(50, "Water");

            vendingMachine.AddStock(crisps);
            vendingMachine.AddStock(water);
        }
    }
}
