using Calculator.Constants;

namespace Calculator.Interface
{
    internal interface ICalculator
    {
        IOperation GetOperation(OperationType type);
    }
}
