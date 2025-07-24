using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Memento
{
    internal class Client
    {
        public Client() 
        {
            var originator = new Originator()
            {
                Name = "Same",
                Description = "Hero",
                Id = 123,
            };


            var caretaker = new Caretaker();

            caretaker.Load(originator);
            caretaker.Save(originator);

            originator.Name = "Carl";
            originator.Description = "Friend";
            originator.Id = 1337;

            caretaker.Load(originator);

            Console.WriteLine($"New state after load " +
                $"- Name: {originator.Name}, " +
                $"Description: {originator.Description}, " +
                $"Id: {originator.Id}.");
        }
    }
}
