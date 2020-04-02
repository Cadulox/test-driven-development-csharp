using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceIssuer.Test
{
    [TestFixture]
    class InvoiceGeneratorTest
    {
        //[Test]
        //public void Should_Generate_Invoice_With_Discounted_Tax_Amount()
        //{
        //    InvoiceGenerator generator = new InvoiceGenerator();
        //    Order order = new Order("Mauricio", 1000.0, 1);

        //    Invoice invoice = generator.Generates(order);

        //    Assert.AreEqual(1000.0 * 0.94, invoice.Value, 0.0001);
        //}

        //[Test]
        //public void Shoul_Persist_Generated_Invoice()
        //{
        //    var dao = new Mock<InvoiceDao>();

        //    InvoiceGenerator generator = new InvoiceGenerator(dao.Object);
        //    Order order = new Order("Mauricio", 1000.0, 1);

        //    Invoice invoice = generator.Generates(order);

        //    dao.Verify(t => t.Persists(invoice));
        //}

        //[Test]
        //public void Should_Send_Generated_Invoice_To_SAP()
        //{
        //    var dao = new Mock<InvoiceDao>();
        //    var sap = new Mock<SAP>();

        //    InvoiceGenerator generator = new InvoiceGenerator(dao.Object, sap.Object);
        //    Order order = new Order("Mauricio", 1000.0, 1);

        //    Invoice invoice = generator.Generates(order);

        //    sap.Verify(t => t.Send(invoice));
        //}

        [Test]
        public void Should_Invoke_Aftwards_Actions()
        {
            IActionAfterGeneratingInvoice action1 = new Mock<IActionAfterGeneratingInvoice>();
            IActionAfterGeneratingInvoice action2 = new Mock<IActionAfterGeneratingInvoice>();

            IList<ActionAfterGeneratingInvoice> actions = new List<ActionAfterGeneratingInvoice>()
            { action1.Object, action2.Object };

            InvoiceGenerator generator = new InvoiceGenerator(actions);
            Order order = new Order("Mauricio", 1000.0, 1);

            Invoice invoice = generator.Generates(order);

            action1.Verify(a => a.Executes(invoice));
            action2.Verify(a => a.Executes(invoice));
        }
    }
}
