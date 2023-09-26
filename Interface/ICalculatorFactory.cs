using Calculator.Constants;

namespace Calculator.Interface
{
    public interface ICalculatorFactory
    {
        ICalculator GetCalculator(CalculatorType type);
    }
}
