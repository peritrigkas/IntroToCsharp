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
            int value ;

            DoWork(invoice, out value);

            Assert.IsTrue(invoice.ID == 4);
            Assert.IsTrue(value == 3);

        }

        void DoWork (Invoice invoice, out int value)
        {
            invoice = new Invoice();
            invoice.ID = 5;
            value = 3;
        }
    
    }
}
