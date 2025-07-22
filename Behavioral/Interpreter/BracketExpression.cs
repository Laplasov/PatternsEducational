using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class BracketExpression : IExpression
    {
        private readonly IExpression _inner;
        public BracketExpression(IExpression inner) => _inner = inner;
        public string Interpret() => "[REDACTED]";
    }
}

