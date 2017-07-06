using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class VendingMachineTest
    {
        public class MockItem : VendingApp.IItem{}

        [TestMethod]
        public void EmptyStockOnSpawn()
        {
            var vendingMachine = new VendingApp.VendingMachine();
            Assert.AreEqual(vendingMachine.Stock.Count, 0);
        }

        [TestMethod]
        public void CanAddStock()
        {
            var vendingMachine = new VendingApp.VendingMachine();
            var goldBars = new MockItem();

            vendingMachine.AddStock(goldBars);

            Assert.IsTrue(vendingMachine.Stock.Contains(goldBars));
            Assert.AreEqual(vendingMachine.stock.Count, 1);
        }
    }
}
