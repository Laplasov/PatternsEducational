using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class Client
    {
        public Client()
        {
            var input = "Example *badword* normal [swear] badword";
            var parser = new ExpressionParser();
            var expression = parser.Parse(input);
            var result = expression.Interpret();

            Console.WriteLine($"Original: {input}");
            Console.WriteLine($"Processed: {result}");
        }
    }
}
