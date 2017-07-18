using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    /// <summary>
    /// Has a stocklist and ActiveMoney, responds as a vendor should
    /// </summary>
    public class VendingMachine
    {
        private readonly ICoinCalculator _coinCalculator;

        public VendingMachine(ICoinCalculator coinCalculator)
        {
            this._coinCalculator = coinCalculator;
        }

        public VendingMachine() : this(new CoinCalculator())
        {
        }

        public int ActiveMoney { get; private set; }

        public List<Item> stock = new List<Item>();
        public List<Item> Stock
        {
            get { return stock; }
            private set { stock = value; }
        }

        public void AddStock(Item newItem)
        {
            Stock.Add(newItem);
        }

        public void InsertCoin(Coin coin)
        {
            ActiveMoney += coin.Value;
        }

        public bool TryPurchase(Item item)
        {
            if (item.Cost > ActiveMoney) { return false; }
            if (!stock.Contains(item)) { return false; }
            ActiveMoney -= item.Cost;
            return true;
        }

        public List<Coin> CoinReturn()
        {
            var moneyToReturn = ActiveMoney;
            ActiveMoney = 0;
            return _coinCalculator.ToCoins(moneyToReturn);
        }
    }
}
