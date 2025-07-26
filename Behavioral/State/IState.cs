using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.State
{
    internal interface IState
    {
        public void StateInfo();
        public void SetState(Context context, LazyStates lazy);
    }
}
