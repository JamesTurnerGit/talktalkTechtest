using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingApp;

namespace VendingAppTests
{
    [TestClass]
    public class CoinTest
    {
        [TestMethod]
        public void CoinHasValue()
        {
            var coinValue = 50;
            var coin = new Coin(coinValue);
            Assert.AreEqual(coinValue, coin.Value);
        }

        [TestMethod]
        public void CoinToStringPence()
        {
            var coinValue = 50;
            var coin = new Coin(coinValue);
            Assert.AreEqual(coin.ToString(), "50 pence coin");
        }

        [TestMethod]
        public void CoinToStringPounds()
        {
            var coinValue = 200;
            var coin = new Coin(coinValue);
            Assert.AreEqual(coin.ToString(), "2 pound coin");
        }

        [TestMethod]
        public void CannotMakeBogusCoins()
        {
            Assert.ThrowsException<ArgumentException>(() => new Coin(3));
            Assert.ThrowsException<ArgumentException>(() => new Coin(111));
        }
    }
}

