using System;

namespace InvoiceIssuer.Domain.Entities
{
    public class Invoice
    {
        public string Client { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public Invoice(string client, double value, DateTime date)
        {
            Client = client;
            Value = value;
            Date = date;
        }
    }
}
