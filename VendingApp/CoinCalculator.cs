using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingApp
{
    interface ICoinCalculator
    {
        List<ICoin> ToCoins(int totalValue);
    }

    public  class CoinCalculator : ICoinCalculator
    { 
        //private ICoin _CoinClass;
        
        //public CoinCalculator (Type coinClass = null)
        //{
        //    Type xx = (Type)Coin;
            // _CoinClass = coinClass ?? tmp.GetType();
            //Type coinClass = tmp.GetType();
        //}

        public List<ICoin> ToCoins(int totalValue)
        {
            var result = new List<ICoin>();

            foreach (int coinValue in Coin.ValidCoinValues)
            {
                while(coinValue <= totalValue)
                {
                    totalValue -= coinValue;
                    result.Add(new Coin(coinValue));
                }
            }
            return result;
        }
    }
}
