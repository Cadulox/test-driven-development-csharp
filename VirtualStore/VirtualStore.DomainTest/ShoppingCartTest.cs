using NUnit.Framework;
using VirtualStore.Domain.Entities;

namespace VirtualStore.DomainTest
{
    [TestFixture]
    class ShoppingCartTest
    {
        private ShoppingCart _cart;

        [SetUp]
        public void Initialize()
        {
            _cart = new ShoppingCart();
        }

        [Test]
        public void ShouldReturnZeroIfEmptyCart()
        {
            Assert.AreEqual(0.0, _cart.MaxValue(), 0.0001);
        }

        [Test]
        public void ShouldReturnValueOfCartForOneItem()
        {
            _cart.Add(new Item("Refrigerator", 1, 900.0));
            Assert.AreEqual(900.0, _cart.MaxValue(), 0.0001);
        }

        [Test]
        public void ShouldReturnMaxValueForManyItems()
        {
            _cart.Add(new Item("Refrigerator", 1, 900.0));
            _cart.Add(new Item("Stove", 1, 1500.0));
            _cart.Add(new Item("Washer", 1, 750.0));

            Assert.AreEqual(1500.0, _cart.MaxValue(), 0.0001);
        }
    }
}
