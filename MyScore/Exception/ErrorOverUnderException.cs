﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyScore.Exception
{
    [Serializable]
    public class ErrorOverUnderException : System.Exception
    {
        public ErrorOverUnderException(string Message) : base(Message) { }
    }
}
