using Decorator.cs.AbstractClasses;

namespace Decorator.cs
{
    class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(BaseComponent comp) : base(comp)
        {
        }

        // Decorators may call parent implementation of the operation, instead
        // of calling the wrapped object directly. This approach simplifies
        // extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
}
