using InvoiceIssuer.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace InvoiceIssuer.Domain.Entities
{
    public class InvoiceGenerator
    {
        private IList<IActionAfterGeneratingInvoice> _actions;
        private IClock _clock;

        public InvoiceGenerator(IList<IActionAfterGeneratingInvoice> actions, IClock clock)
        {
            _actions = actions;
            _clock = clock;
        }

        public InvoiceGenerator(IList<IActionAfterGeneratingInvoice> actions) :
        this(actions, new SystemClock())
        { }

        public Invoice Generates(Order order)
        {
            Invoice invoice = new Invoice(
                order.Client,
                order.TotalValue * 0.94,
                DateTime.Now);

            foreach (var action in _actions)
            {
                action.Executes(invoice);
            }

            return invoice;
        }
    }
}
