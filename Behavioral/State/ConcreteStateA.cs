using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    internal class ConcreteStateA : IState
    {
        public void SetState(Context context, LazyStates lazy) => context.State = lazy.B;
        public void StateInfo() => Console.WriteLine($"Current state - {this.GetType().Name}");
    }
}
