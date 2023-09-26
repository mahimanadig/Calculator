using Calculator.ArithmeticOperaton;
using Calculator.Constants;
using Calculator.Interface;

namespace Calculator
{
    internal class ArithmeticCalculator : ICalculator
    {
        public IOperation GetOperation(OperationType type)
        {
            switch (type)
            {
                case OperationType.Addition:
                    return new Addition();
                case OperationType.Subtraction:
                    return new Subtraction();
                case OperationType.Division:
                    return new Division();
                case OperationType.Multiplication:
                    return new Multiplication();
                default:
                    return null;
            }
        }
    }
}
