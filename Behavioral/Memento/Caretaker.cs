using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Patterns.Behavioral.Memento
{
    internal class Caretaker
    {
        private readonly Stack<Memento> m_history = new();
        public void Save(Originator originator)
        {
            Console.WriteLine($"Originator get saved - " +
                $"Name: {originator.Name}, " +
                $"Description: {originator.Description}, " +
                $"Id: {originator.Id}.");

            m_history.Push(originator.Save());
        }

        public void Load(Originator originator)
        {
            if (m_history.Count == 0)
            {
                Console.WriteLine("No new Memento!");
                return;
            }

            Console.WriteLine($"Originator get loaded, state before load - " +
                $"Name: {originator.Name}, " +
                $"Description: {originator.Description}, " +
                $"Id: {originator.Id}.");

            originator.Load(m_history.Pop());
        }
    }
}
