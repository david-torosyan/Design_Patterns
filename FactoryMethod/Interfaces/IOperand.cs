using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Interfaces
{
    public interface IOperand<T>
    {
        T Sum(T first, T second);
        T Multiply(T first, T second);
    }
}
