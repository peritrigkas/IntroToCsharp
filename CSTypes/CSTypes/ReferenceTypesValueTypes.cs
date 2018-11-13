using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSTypes
{
    public class Invoice
        {
            public string Description {get; set;}
            public decimal Amount {get; set;}
            public int ID {get; set;}
        }

    [TestClass]
    public class ReferenceTypesValueTypes
    {
        

        [TestMethod]
        public void PassbyValue()
        {
            Invoice invoice = new Invoice();
            invoice.ID = 4;
            int value = 5;

            DoWork(invoice, value);

            Assert.IsTrue(invoice.ID == 9);
            Assert.IsTrue(value == 5);

        }

        void DoWork (Invoice invoice, int value)
        {
            invoice.ID = 9;
            value = 13;
        }
    
    }
}
