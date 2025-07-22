using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class ExpressionParser
    {
        public IExpression Parse(string input)
        {
            var tokens = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var expressions = new Stack<IExpression>();

            foreach (var token in tokens)
            {
                IExpression expr = new TerminalExpression(token);

                if (token.StartsWith("*") && token.EndsWith("*"))
                {
                    expr = new RepeatExpression(expr);
                }
                else if (token.StartsWith("[") && token.EndsWith("]"))
                {
                    expr = new BracketExpression(expr);
                }

                expressions.Push(expr);
            }

            while (expressions.Count > 1)
            {
                var right = expressions.Pop();
                var left = expressions.Pop();
                expressions.Push(new SequenceExpression(left, right));
            }

            return expressions.Pop();
        }
    }
}
