using Calculator.Interface;
using Calculator.Result;

namespace Calculator.ArithmeticOperaton
{
    public class Subtraction : IOperation
    {
        public IResult Calculate(double param1, double param2)
        {
            return new ArithmeticResult { Value = param1 - param2 };
        }
    }
}
