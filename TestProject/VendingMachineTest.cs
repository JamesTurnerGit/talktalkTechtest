using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class VendingMachineTest
    {
        public class MockItem : VendingApp.IItem{
            public int Cost    { get; set; }
            public string Name { get; set; }
        }

        public class MockCoin : VendingApp.ICoin
        {
            public int Value { get; set; }
        }

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
            var goldBars = new MockItem { Name = "goldBar", Cost = 5000 };

            vendingMachine.AddStock(goldBars);

            Assert.IsTrue(vendingMachine.Stock.Contains(goldBars));
            Assert.AreEqual(vendingMachine.stock.Count, 1);
        }

        [TestMethod]
        public void HasZeroInAtStart()
        {
            var vendingMachine = new VendingApp.VendingMachine();
            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void TotalGetsSingleCoinAdded()
        {
            var vendingMachine = new VendingApp.VendingMachine();
            var mockPoundCoin = new MockCoin { Value = 100 };

            vendingMachine.InsertCoin(mockPoundCoin);
            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(100, total);
        }


        [TestMethod]
        public void TotalGetsMultibleCoinsAdded()
        {
            var vendingMachine = new VendingApp.VendingMachine();
            var mockPoundCoin = new MockCoin { Value = 100 };

            vendingMachine.InsertCoin(mockPoundCoin);
            vendingMachine.InsertCoin(mockPoundCoin);

            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(200, total);
        }

    }
}
