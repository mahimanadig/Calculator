using Calculator.Interface;
using Calculator.Result;

namespace Calculator.ArithmeticOperaton
{
    internal class Addition : IOperation
    {
        public IResult Calculate(double param1, double param2)
        {
            return new ArithmeticResult { Value = param1 + param2 };
        }
    }
}
