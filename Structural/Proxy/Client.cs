using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Structural.Proxy
{
    enum AccessType { Full, Read, Write, Zero }
    internal class Client
    {
        public Client() 
        {
            RealSubject subject = new();
            Proxy proxyZero = new(AccessType.Zero, subject);
            Proxy proxyWrite = new(AccessType.Write, subject);
            Proxy proxyRead = new(AccessType.Read, subject);

            Console.WriteLine("RealSubject.");
            subject.Show();
            subject.Edit();

            Console.WriteLine();
            Console.WriteLine("Proxy Zero.");
            proxyZero.Show();
            proxyZero.Edit();

            Console.WriteLine();
            Console.WriteLine("Proxy Write.");
            proxyWrite.Show();
            proxyWrite.Edit();

            Console.WriteLine();
            Console.WriteLine("Proxy Read.");
            proxyRead.Show();
            proxyRead.Edit();

        }
    }
}
