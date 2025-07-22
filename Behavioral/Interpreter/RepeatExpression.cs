using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class RepeatExpression : IExpression
    {
        private readonly IExpression _inner;
        public RepeatExpression(IExpression inner) => _inner = inner;
        public string Interpret() => new string('*', _inner.Interpret().Length);
    }

}
