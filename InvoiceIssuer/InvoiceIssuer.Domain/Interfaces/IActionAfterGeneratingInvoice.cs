using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IActionAfterGeneratingInvoice
    {
        void Executes(Invoice invoice);
    }
}
