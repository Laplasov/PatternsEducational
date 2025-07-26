using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Strategy
{
    internal class Context
    {
        public List<IStrategy> _strategies = new();
        public List<IStrategy> _strategiesOptimized = new();
        public string Message { get; set; }
        public Context(string massage) => Message = massage;
        public void SetMessage(string massage) => Message = massage;

        public void SetStrategies(IStrategy strategy, bool optimized)
        {
            if (!optimized)
            {
                _strategies.Clear();
                _strategies.Add(strategy);
            }
            else
            {
                _strategiesOptimized.Clear();
                _strategiesOptimized.Add(strategy);
            }
        }

        public void AddSubStrategy(IStrategy strategy, bool optimized)
        {
            if (!optimized)
                _strategies.Add(strategy);
            else
                _strategiesOptimized.Add(strategy);
        }

        public void Execute(bool optimized)
        {
            if (!optimized)
            {
                foreach (IStrategy strategy in _strategies)
                    strategy.Execute(Message);
            }
            else
            {
                foreach (IStrategy strategy in _strategiesOptimized)
                    strategy.Execute(Message);
            }
        }

    }
}
