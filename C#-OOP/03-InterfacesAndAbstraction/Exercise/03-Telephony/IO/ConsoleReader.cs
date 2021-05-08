using Exer_03.Telephony.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.Telephony.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
