using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class ItemTest
    {

        [TestMethod]
        public void ItemHasName()
        {
            var itemName = "crisps";
            var item = new VendingApp.Item(30, itemName); 
            Assert.AreEqual(itemName, item.Name);
        }

        [TestMethod]
        public void ItemHasCost()
        {
            var itemCost = 50;
            var item = new VendingApp.Item(itemCost, "crisps");
            Assert.AreEqual(itemCost, item.Cost);
        }
    }
}
