using System.Collections.Generic;

namespace VirtualStore.Domain.Entities
{
    public class ShoppingCart
    {
        public IList<Item> Items { get; private set; }

        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public double MaxValue()
        {
            if (Items.Count == 0) return 0;

            double major = Items[0].TotalValue;
            foreach (var item in Items)
            {
                if (major < item.TotalValue)
                {
                    major = item.TotalValue;
                }
            }

            return major;
        }
    }
}
