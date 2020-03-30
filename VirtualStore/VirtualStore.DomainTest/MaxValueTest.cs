using NUnit.Framework;
using VirtualStore.Domain.Entities;

namespace VirtualStore.DomainTest
{
    [TestFixture]
    class MaxValueTest
    {
        [Test]
        public void ShouldReturnZeroIfEmptyCart()
        {
            ShoppingCart cart = new ShoppingCart();           

            Assert.AreEqual(0.0, cart.MaxValue(), 0.0001);
        }

        [Test]
        public void ShouldReturnValueOfCartForOneItem()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new Item("Refrigerator", 1, 900.0));

            Assert.AreEqual(900.0, cart.MaxValue(), 0.0001);
        }

        [Test]
        public void ShouldReturnMaxValueForManyItems()
        {
            ShoppingCart cart = new ShoppingCart();
            cart.Add(new Item("Refrigerator", 1, 900.0));
            cart.Add(new Item("Stove", 1, 1500.0));
            cart.Add(new Item("Washer", 1, 750.0));

            Assert.AreEqual(1500.0, cart.MaxValue(), 0.0001);
        }
    }
}
