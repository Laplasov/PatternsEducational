using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Interpreter
{
    internal class TerminalExpression : IExpression
    {
        private readonly string m_string;
        private static readonly List<string> m_badWords = new List<string>()
    {
        "badword",
        "swear",
        "inappropriate",
        "offensive",
        "profanity"
    };

        public TerminalExpression(string text)
        {
            m_string = text;
        }

        public string Interpret()
        {
            foreach (var badWord in m_badWords)
            {
                if (m_string.Contains(badWord, StringComparison.OrdinalIgnoreCase))
                {
                    return "[CONTENT REMOVED]";
                }
            }

            return m_string;
        }
    }
}
