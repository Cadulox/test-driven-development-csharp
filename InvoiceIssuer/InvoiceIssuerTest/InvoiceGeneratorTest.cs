using InvoiceIssuer.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceIssuer.Test
{
    [TestFixture]
    class InvoiceGeneratorTest
    {
        [Test]
        public void Should_Generate_Invoice_With_Discounted_Tax_Amount()
        {
            InvoiceGenerator generator = new InvoiceGenerator();
            Order order = new Order("Mauricio", 1000.0, 1);

            Invoice invoice = generator.Generates(order);

            Assert.AreEqual(1000.0 * 0.94, invoice.Value, 0.0001);
        }
    }
}
