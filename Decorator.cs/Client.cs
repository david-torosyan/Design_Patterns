using Decorator.cs.AbstractClasses;
using System.ComponentModel;

namespace Decorator.cs
{
    public class Client
    {
        // The client code works with all objects using the Component interface.
        // This way it can stay independent of the concrete classes of
        // components it works with.
        public void ClientCode(BaseComponent component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}