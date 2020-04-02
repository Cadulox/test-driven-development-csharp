using InvoiceIssuer.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceIssuer.Domain.Entities
{
    public class SystemClock : IClock
    {
        public DateTime Today()
        {
            return DateTime.Now;
        }
    }
}
