using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingApp;

namespace VendingAppTests
{
    [TestClass]
    public class CoinCalculatorTest
    {
        [TestMethod]
        public void CanConvertSimpleCoins()
        {
            var cc = new CoinCalculator();
            var coinValue = 5;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(coinValue, result[0].Value);
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void CanConvertIntoMultibleCoins()
        {
            var cc = new CoinCalculator();
            var coinValue = 51;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(50, result[0].Value);
            Assert.AreEqual(1, result[1].Value);
            Assert.AreEqual(2, result.Count);
        }
        [TestMethod]
        public void ManyCoinConversion()
        {
            var cc = new CoinCalculator();
            var coinValue = 388;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(200, result[0].Value);
            Assert.AreEqual(100, result[1].Value);
            Assert.AreEqual(50, result[2].Value);
            Assert.AreEqual(20, result[3].Value);
            Assert.AreEqual(10, result[4].Value);
            Assert.AreEqual(5, result[5].Value);
            Assert.AreEqual(2, result[6].Value);
            Assert.AreEqual(1, result[7].Value);
            Assert.AreEqual(8, result.Count);
        }
        [TestMethod]
        public void MultibleOfSameCoin()
        {
            var cc = new CoinCalculator();
            var coinValue = 4;
            var result = cc.ToCoins(coinValue);

            Assert.AreEqual(2, result[0].Value);
            Assert.AreEqual(2, result[1].Value);
            Assert.AreEqual(2, result.Count);
        }
    }
}
