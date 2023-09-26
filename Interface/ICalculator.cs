using Calculator.Constants;

namespace Calculator.Interface
{
    public interface ICalculator
    {
        IOperation GetOperation(OperationType type);
    }
}
