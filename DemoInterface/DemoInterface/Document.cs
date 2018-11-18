﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInterface
{
    class Document : IStorable, ISpeak
    {
        public void Reformat()
        {
            Console.WriteLine("Refoprmatting the Document");
        }

        public void Read(string nameOfFile)
        {
            Console.WriteLine($"Reading from {nameOfFile}");
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"Writing to {fileName}");
        }

        public double DurationOfSpeech
        {
            get { return 42; }
        }

        public void Speak()
        {
            Console.WriteLine("Speaking ...");
        }
    }
}
