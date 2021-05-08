using Exer_03.Telephony.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.Telephony.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            System.Console.Write(text);  
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
