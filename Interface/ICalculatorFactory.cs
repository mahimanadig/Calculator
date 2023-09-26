using Calculator.Constants;

namespace Calculator.Interface
{
    internal interface ICalculatorFactory
    {
        ICalculator GetCalculator(CalculatorType type);
    }
}
