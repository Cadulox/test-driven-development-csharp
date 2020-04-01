namespace InvoiceIssuer.Domain.Entities
{
    public class Order
    {
        public string Client { get; set; }
        public double TotalValue { get; set; }
        public int QuantityItems { get; set; }

        public Order(string client, double totalValue, int quantityItems)
        {
            Client = client;
            TotalValue = totalValue;
            QuantityItems = quantityItems;
        }
    }
}
