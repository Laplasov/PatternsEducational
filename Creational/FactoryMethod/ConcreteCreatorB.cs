﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.FactoryMethod
{
    internal class ConcreteCreatorB : Creator
    {
        public override Product CreateProduct(string name) => new ConcreteProductB(name);
    }
}
