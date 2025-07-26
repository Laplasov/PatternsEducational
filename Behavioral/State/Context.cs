using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    internal class Context
    {
        private LazyStates _states = new LazyStates();
        public IState State { get; set; } 
        public Context() => State = _states.A;
        public void SetState() => State.SetState(this, _states);
        public void StateInfo() => State.StateInfo();
    }
}
