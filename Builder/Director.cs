using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    internal class Director
    {
        public IBuilder Builder { get; set; }
        public Director(IBuilder builder) => Builder = builder;
        public void SetBuilder(IBuilder builder) => Builder = builder;
        internal void Build(TopObject topObject)
        {
            Builder.BuildPartA(topObject.Name);
            Builder.BuildPartB(topObject.Id);
            Builder.BuildPartC(topObject.Location);
            Builder.BuildPartD(topObject.Comment);
        }
        internal void BuildMix(TopObject topObjectOne, TopObject topObjectTwo)
        {
            Builder.BuildPartA(topObjectOne.Name);
            Builder.BuildPartB(topObjectTwo.Id);
            Builder.BuildPartC(topObjectTwo.Location);
            Builder.BuildPartD(topObjectTwo.Comment);
        }

    }
}
