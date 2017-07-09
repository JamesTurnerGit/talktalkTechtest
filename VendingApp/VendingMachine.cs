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
        public CoinCalculator coinCalculator = new CoinCalculator();

        public int ActiveMoney { get; private set; }
        public List<IItem> Stock
        {
            get { return stock; }
            private set { stock = value; }
        }

        public void AddStock(IItem newItem)
        {
            Stock.Add(newItem);
        }

        public void InsertCoin(ICoin coin)
        {
            ActiveMoney += coin.Value;
        }

        public bool TryPurchase(IItem item)
        {
            if (item.Cost > ActiveMoney) { return false; }
            if (!stock.Contains(item)) { return false; }
            ActiveMoney -= item.Cost;
            return true;
        }

        public List<ICoin> CoinReturn()
        {
            var moneyToReturn = ActiveMoney;
            ActiveMoney = 0;
            return coinCalculator.ToCoins(moneyToReturn);
        }
    }
}
