﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal interface IExpression
    {
        public string Interpret();
    }
}
