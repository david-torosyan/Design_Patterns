using Decorator.cs.AbstractClasses;

namespace Decorator.cs
{
    abstract class Decorator : BaseComponent
    {
        protected BaseComponent _BaseComponent;

        public Decorator(BaseComponent BaseComponent)
        {
            this._BaseComponent = BaseComponent;
        }

        public void SetBaseComponent(BaseComponent BaseComponent)
        {
            this._BaseComponent = BaseComponent;
        }

        // The Decorator delegates all work to the wrapped BaseComponent.
        public override string Operation()
        {
            if (this._BaseComponent != null)
            {
                return this._BaseComponent.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
