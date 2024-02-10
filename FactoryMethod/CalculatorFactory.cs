using FactoryMethod.AbstractClass;
using FactoryMethod.Enum;
using FactoryMethod.FactorClasses;

namespace FactoryMethod
{
    public class CalculatorFactory
    {
        public static Calculator Create(CalculatorTypeEnum calculatorType)
        {
            switch (calculatorType)
            {
                case CalculatorTypeEnum.Digit:
                    return new SimpleCalculator();
                case CalculatorTypeEnum.Complex:
                    return new ComplexCalculator();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
