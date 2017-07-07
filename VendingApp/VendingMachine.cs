using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    public class VendingMachine
    {
        public List<IItem> stock = new List<IItem>();
        public List<IItem> Stock
        {
            get { return stock; }
            private set { stock = value; }
        }

        public void AddStock(IItem newItem)
        {
            Stock.Add(newItem);
        }

    }
}
