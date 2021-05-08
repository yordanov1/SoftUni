using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.Telephony.Contracts
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text); 
    }
}
