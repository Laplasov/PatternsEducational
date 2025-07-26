using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    internal class LazyStates
    {
        private readonly Lazy<IState> _stateA = new Lazy<IState>(() => new ConcreteStateA());
        private readonly Lazy<IState> _stateB = new Lazy<IState>(() => new ConcreteStateB());
        private readonly Lazy<IState> _stateC = new Lazy<IState>(() => new ConcreteStateC());

        public IState A => _stateA.Value;
        public IState B => _stateB.Value;   
        public IState C => _stateC.Value;
    }
}
