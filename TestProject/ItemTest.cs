using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingApp;

namespace VendingAppTests
{
    [TestClass]
    public class ItemTest
    {

        [TestMethod]
        public void ItemHasName()
        {
            var itemName = "crisps";
            var item = new Item(30, itemName); 
            Assert.AreEqual(itemName, item.Name);
        }

        [TestMethod]
        public void ItemHasCost()
        {
            var itemCost = 50;
            var item = new Item(itemCost, "crisps");
            Assert.AreEqual(itemCost, item.Cost);
        }
    }
}
