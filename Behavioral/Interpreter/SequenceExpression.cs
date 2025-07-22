using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class SequenceExpression : IExpression
    {
        private readonly IExpression _left, _right;
        public SequenceExpression(IExpression l, IExpression r) => (_left, _right) = (l, r);
        public string Interpret() => $"{_left.Interpret()} | {_right.Interpret()}";
    }
}
