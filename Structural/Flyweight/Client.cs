using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Flyweight
{
    enum FlyweightType { Simon, Lillo }
    internal class Client
    {
        public Client() 
        { 
            var factory = new FlyweightFactory();
            factory.GetData(FlyweightType.Simon).Say("Hi!");
            factory.GetData(FlyweightType.Simon).Say("How are you!");
            factory.GetData(FlyweightType.Lillo).Say("Good!");
            factory.GetData(FlyweightType.Simon).Say("Great! // Reuses Simon instance");
        }
    }
}
