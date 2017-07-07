using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class CoinCalculatorTest
    {
        [TestMethod]
        public void CanConvertSimpleCoins()
        {
            var cc = new VendingApp.CoinCalculator();
            var coinValue = 5;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(coinValue, result[0].Value);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void CanConvertMultibleCoins()
        {
            var cc = new VendingApp.CoinCalculator();
            var coinValue = 51;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(50, result[0].Value);
            Assert.AreEqual(1, result[1].Value);
            Assert.AreEqual(2, result.Count);
        }
    }
}
