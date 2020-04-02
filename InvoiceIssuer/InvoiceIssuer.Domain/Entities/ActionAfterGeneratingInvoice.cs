using InvoiceIssuer.Domain.Interfaces;


namespace InvoiceIssuer.Domain.Entities
{
    public class ActionAfterGeneratingInvoice : IActionAfterGeneratingInvoice
    {
        public void Executes(Invoice invoice)
        {
        }
    }
}
