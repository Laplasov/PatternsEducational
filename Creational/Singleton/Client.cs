using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singleton
{
    internal class Client
    {
        public Client() 
        {
            Console.WriteLine("Testing Singleton A:");
            var singleton_A = SingletonA.Instance;
            Console.WriteLine(singleton_A.GetInfo());
            var singletonA_Ref = SingletonA.Instance;
            Console.WriteLine("Referents A:");
            Console.WriteLine(ReferenceEquals(singleton_A, singletonA_Ref));
            Console.WriteLine();

            Console.WriteLine("Testing Singleton B:");
            var singleton_B = SingletonB.Instance;
            Console.WriteLine(singleton_B.GetInfo());
            var singletonB_Ref = SingletonB.Instance;
            Console.WriteLine("Referents B:");
            Console.WriteLine(ReferenceEquals(singleton_B, singletonB_Ref));
            Console.WriteLine();

            Console.WriteLine("Is A = B:");
            Console.WriteLine(ReferenceEquals(singleton_A, singleton_B));
            Console.WriteLine();

            Console.WriteLine("Registry:");
            foreach (ISingleton instance in SingletonRegistry.GetAllInstances())
                Console.WriteLine(instance.GetInfo());
            
        }
    }
}
