namespace VirtualStore.Domain.Entities
{
    public class Item
    {
        public string Description { get; private set; }
        public int Amount { get; set; }
        public double UnitValue { get; set; }

        public Item(string description, int amount, double unitValue)
        {
            Description = description;
            Amount = amount;
            UnitValue = unitValue;
        }

        public double TotalValue
        {
            get { return UnitValue * Amount; }
        }
    }
}
