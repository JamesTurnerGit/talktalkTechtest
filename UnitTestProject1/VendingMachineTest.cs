using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingApp
{
    [TestClass]
    public class VendingMachineTest
    {
        [TestMethod]
        public void EmptyStockOnSpawn()
        {
            var vendingMachine = new VendingMachine();
            Assert.AreEqual(vendingMachine.Stock.Count, 0);
        }
        [TestMethod]
        public void CanAddStock()
        {
            var vendingMachine = new VendingMachine();
            var goldBars = new Item();
            vendingMachine.AddStock(goldBars);
            Assert.IsTrue(vendingMachine.Stock.Contains(goldBars));
            Assert.AreEqual(vendingMachine.stock.Count, 1);
        }
    }
}
