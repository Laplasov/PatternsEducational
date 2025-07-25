using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Observer
{
    internal class Client
    {
        public Client() 
        {
            var controller = new Controller<string>();

            Console.WriteLine("Observer A subscribed");
            var observerA = controller.Subscribe(new Observer<string>("A"));

            controller.Publish("Hello");
            controller.Publish("World");

            Console.WriteLine("Observer B subscribed");
            var observerB = controller.Subscribe(new Observer<string>("B"));

            controller.Publish("Hello");
            controller.Publish("World");

            Console.WriteLine("Observer A unsubscribed");
            observerA.Dispose();

            controller.Publish("Hello");
            controller.Publish("World");

        }
    }
}
