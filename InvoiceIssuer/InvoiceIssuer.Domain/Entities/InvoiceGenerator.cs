using System;

namespace InvoiceIssuer.Domain.Entities
{
    public class InvoiceGenerator
    {
        public Invoice Generates(Order order)
        {
            return new Invoice(
                order.Client,
                order.TotalValue * 0.94,
                DateTime.Now);
        }
    }
}
