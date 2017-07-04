using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingApp
{
    [TestClass]
    public class ItemTest
    {
        [TestMethod]
        public void ItemHasName()
        {
            var itemName = "crisps";
            var item = new Item { Name = itemName };
            Assert.AreEqual(itemName, item.Name);
        }
        [TestMethod]
        public void ItemHasCost()
        {
            var itemCost = 50;
            var item = new Item { Cost = itemCost };
            Assert.AreEqual(itemCost, item.Cost);
        }
    }
}
