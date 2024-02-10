using Decorator.cs.AbstractClasses;
using System.ComponentModel;

namespace Decorator.cs.ConcorateComponents
{
    class ConcreteComponent : BaseComponent
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
