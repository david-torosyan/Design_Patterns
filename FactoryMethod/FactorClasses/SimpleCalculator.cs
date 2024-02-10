using FactoryMethod.AbstractClass;
using FactoryMethod.Interfaces;

namespace FactoryMethod.FactorClasses
{
    public class SimpleCalculator : Calculator, IOperand<double>
    {
        internal SimpleCalculator()
        {
            MemoryNumber = "0";
        }
        public string MemoryNumber { get; set; }
        public double Sum(double first, double second)
        {
            return first + second;
        }
        public double Multiply(double first, double second)
        {
            return first * second;
        }
        public override string Calculate(string first, string second, string operation)
        {
            double firstArg = Convert.ToDouble(first);
            double secondArg = Convert.ToDouble(second);
            switch (operation)
            {
                case "+":
                    return Sum(firstArg, secondArg).ToString();
                case "*":
                    return Multiply(firstArg, secondArg).ToString();
                default:
                    throw new Exception("No such operation!");
            }
        }
    }
}
