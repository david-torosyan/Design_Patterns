using FactoryMethod.AbstractClass;
using FactoryMethod.Interfaces;
using System.Numerics;

namespace FactoryMethod.FactorClasses
{
    public class ComplexCalculator : Calculator, IOperand<Complex>
    {
        internal ComplexCalculator()
        {
            MemoryNumber = "0";
        }
        public string MemoryNumber { get; set; }
        public Complex Sum(Complex first, Complex second)
        {
            return first + second;
        }
        public Complex Multiply(Complex first, Complex second)
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
