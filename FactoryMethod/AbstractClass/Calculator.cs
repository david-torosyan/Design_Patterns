﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.AbstractClass
{
    public abstract class Calculator
    {
        public abstract string Calculate(string first, string second, string operation);
    }
}
