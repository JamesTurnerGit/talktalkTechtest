using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    public class VendingMachine
    {
        public List<Item> stock = new List<Item>();
        public List<Item> Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public void AddStock(Item newItem)
        {
            Stock.Add(newItem);
        }


    }
}
