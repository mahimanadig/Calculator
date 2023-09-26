using Calculator.Constants;
using Calculator.Interface;

namespace Calculator
{
    internal class CalculatorProvider : ICalculatorFactory
    {
        public ICalculator GetCalculator(CalculatorType type)
        {
            switch(type)
            {
                case CalculatorType.Arithmetic:
                    return new ArithmeticCalculator();
                default:
                    return null;
            }
        }
    }
}
