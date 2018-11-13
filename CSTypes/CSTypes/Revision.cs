using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSTypes
{
    public class Revision
    {
        public string Subject { get; set; }
        public int Hours { get; set; } 
        
    }
    [TestClass]

    public class Study 
    {
        [TestMethod]
        public void Work()
        {
            Revision revision = new Revision();
            revision.Hours = 4;
            revision.Subject = "Algebra";
            int Hours;
            HomeWork(out revision, out Hours);

            Assert.IsTrue(revision.Subject == "History");
            Assert.IsTrue(Hours == 7);
        }
        void HomeWork( out Revision revision, out int Hours)
        {
            revision = new Revision();
            revision.Subject = "History";
            Hours = 7;
            

        }

        



    }
        
    
}
