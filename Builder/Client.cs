using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Patterns.Builder.Client;

namespace Patterns.Builder
{
    internal class Client
    {
        internal enum BuilderType { BuilderA, BuilderB, BuilderC }

        Director director;
        IBuilder builder;

        Dictionary<BuilderType, IBuilder> BuilderCollection = new Dictionary<BuilderType, IBuilder>() 
        {
            {BuilderType.BuilderA, new ConcreteBuilderA() },  
            {BuilderType.BuilderB, new ConcreteBuilderB() },
            {BuilderType.BuilderC, new ConcreteBuilderC() }
        };
        TopObject topObjectOne = new TopObject()
        {
            Name = "Same",
            Id = 145,
            Location = "London",
            Comment = "Hello world!",
        };

        TopObject topObjectTwo = new TopObject()
        {
            Name = "Nataly",
            Id = 1337,
            Location = "Panama",
            Comment = "All your base...",
        };


        internal Client() 
        {
            builder = BuilderCollection[BuilderType.BuilderA];
            director = new Director(builder);

            Console.WriteLine("Test A builder -\n\n");
            Test();

            builder = BuilderCollection[BuilderType.BuilderB];
            director = new Director(builder);

            Console.WriteLine("Test B builder -\n\n");
            Test();

            builder = BuilderCollection[BuilderType.BuilderC];
            director = new Director(builder);

            Console.WriteLine("Test B builder -\n\n");
            Test();
        }

        void Test()
        {

            director.Build(topObjectOne);
            Console.WriteLine("Build:\n");
            Console.WriteLine(builder.GetResult());
            builder.Reset();

            director.BuildMix(topObjectOne, topObjectTwo);
            Console.WriteLine("BuildMix:\n");
            Console.WriteLine(builder.GetResult());
            builder.Reset();
        }
    }
}
