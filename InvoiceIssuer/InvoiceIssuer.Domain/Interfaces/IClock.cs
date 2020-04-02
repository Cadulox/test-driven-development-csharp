using System;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IClock
    {
        DateTime Today();
    }
}
