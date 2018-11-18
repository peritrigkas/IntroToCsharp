﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    public class Worker
    {

        public Worker()
        {
            Work();
        }
        public void Work()
        {
            Document doc1 = new Document();
            doc1.Reformat();
            doc1.Read("myFile");
            doc1.Speak();

            IStorable doc2 = new Document();
            doc2.Read("myFile");
            doc2.Write("myFile");
            //doc2.Speak();

            ISpeak doc3 = new Document();
            doc3.Speak();
            //doc3.Read();

            Document doc4 = new Memo();
            doc4.Reformat();
            doc4.Read("MyFile");
            //doc4.MemoTo = "Jessie";

            Memo doc5 = new Memo();
            doc5.Read("myFile");
            doc5.Reformat();
            doc5.MemoTo = "Jessie";



        }
    }
}
