﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingApp;

namespace VendingAppTests
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
            var goldBars = new Item(5000, "goldBar");

            vendingMachine.AddStock(goldBars);

            Assert.IsTrue(vendingMachine.Stock.Contains(goldBars));
            Assert.AreEqual(vendingMachine.stock.Count, 1);
        }

        [TestMethod]
        public void HasZeroInAtStart()
        {
            var vendingMachine = new VendingMachine();
            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(0, total);
        }

        [TestMethod]
        public void TotalGetsSingleCoinAdded()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin (100);

            vendingMachine.InsertCoin(mockPoundCoin);
            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(100, total);
        }


        [TestMethod]
        public void TotalGetsMultibleCoinsAdded()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);

            vendingMachine.InsertCoin(mockPoundCoin);
            vendingMachine.InsertCoin(mockPoundCoin);

            var total = vendingMachine.ActiveMoney;

            Assert.AreEqual(200, total);
        }

        [TestMethod]
        public void CanPurchaseItems()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);
            var twinkies = new Item(100, "twinkies");

            vendingMachine.AddStock(twinkies);
            vendingMachine.InsertCoin(mockPoundCoin);

            Assert.IsTrue(vendingMachine.TryPurchase(twinkies));
        }

        [TestMethod]
        public void CantPurchaseIfGoodsTooExpensive()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);
            var kingSizeTwix = new Item(101, "king Size Twix");

            vendingMachine.AddStock(kingSizeTwix);
            vendingMachine.InsertCoin(mockPoundCoin);

            Assert.IsFalse(vendingMachine.TryPurchase(kingSizeTwix));
        }

        [TestMethod]
        public void CantPurchaseIfGoodsNotInStock()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);
            var kingSizeTwix = new Item(101, "king Size Twix");

            vendingMachine.InsertCoin(mockPoundCoin);

            Assert.IsFalse(vendingMachine.TryPurchase(kingSizeTwix));
        }

        [TestMethod]
        public void SubtractsCostFromTotal()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);

            var twinkies = new Item(100, "twinkies");

            vendingMachine.AddStock(twinkies);
            vendingMachine.InsertCoin(mockPoundCoin);

            vendingMachine.TryPurchase(twinkies);

            Assert.AreEqual(vendingMachine.ActiveMoney, 0);

        }

        [TestMethod]
        public void CoinReturnWorks()
        {
            var vendingMachine = new VendingMachine();
            var mockPoundCoin = new Coin(100);

            vendingMachine.InsertCoin(mockPoundCoin);
            var change = vendingMachine.CoinReturn();

            Assert.AreEqual(100, change[0].Value);
        }

        [TestMethod]
        public void CoinReturnSetsValueToZero()
        {
            var vendingMachine = new VendingMachine();

            var mockPoundCoin = new Coin(100);
            vendingMachine.InsertCoin(mockPoundCoin);

            vendingMachine.CoinReturn();

            Assert.AreEqual(0, vendingMachine.ActiveMoney);
        }
    }
}
