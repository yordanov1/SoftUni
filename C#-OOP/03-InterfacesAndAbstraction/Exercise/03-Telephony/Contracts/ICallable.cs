﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exer_03.Telephony.Contracts
{
    public interface ICallable
    {
        string Call(string number);
    }
}
