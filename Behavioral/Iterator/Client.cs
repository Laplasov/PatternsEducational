using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Behavioral.Iterator
{
    internal class Client
    {
        public Client() 
        {
            var collection = new WordsCollection();
            collection.AddWord("Design");
            collection.AddWord("Patterns");
            collection.AddWord("Iterator");

            foreach (var word in collection)
                Console.WriteLine(word);
        }
    }
}
