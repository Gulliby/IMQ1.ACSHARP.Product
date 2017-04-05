using IMQ1.ACSHARP.Product.Library.Shop;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IMQ1.ACSHARP.Product.Library.Tests.Unit.Shop
{
    [TestClass]
    public class ShopItemTests
    {
        [TestMethod]
        public void ShopItems_WithEqualProperties_Are_Equal()
        {
            // arrange
            var firstShopItem = new ShopItem("QWERTY", 20, 10);
            var secondShopItem = new ShopItem("QWERTY", 20, 10);

            // act
            var result = firstShopItem.Equals(secondShopItem);

            // assert
            Assert.IsTrue(result);
        }
    }
}
