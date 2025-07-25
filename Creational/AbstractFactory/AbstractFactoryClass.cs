﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.AbstractFactory
{
    public class AbstractFactoryClass
    {
        public AbstractFactoryClass()
        {
            Client client = new Client();

            IAbstractFactory FactoryA = client.CreateFactory(FactoryType.A);
            Console.WriteLine(FactoryA.CreateProductA().Name);
            Console.WriteLine(FactoryA.CreateProductB().Name);

            IAbstractFactory FactoryB = client.CreateFactory(FactoryType.B);
            Console.WriteLine(FactoryB.CreateProductA().Name);
            Console.WriteLine(FactoryB.CreateProductB().Name);

            try
            {
                IAbstractFactory FactoryError = client.CreateFactory(FactoryType.None);
                Console.WriteLine(FactoryError.CreateProductA().Name);
                Console.WriteLine(FactoryError.CreateProductB().Name);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
