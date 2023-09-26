using Calculator.Constants;
using Calculator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorService
    {
        private readonly ICalculatorFactory _calculatorFactory;
        private ICalculator _calculator;
        private IOperation _operation;

        public CalculatorService(ICalculatorFactory calculatorFactory)
        {
            _calculatorFactory = calculatorFactory;
        }

        public void SetCalculator(CalculatorType type)
        {
            _calculator = _calculatorFactory.GetCalculator(type);
        }

        public void SetOperation(OperationType type)
        {
           _operation = _calculator.GetOperation(OperationType.Addition);
        }

        public IResult Calculate(double param1, double param2)
        {
            return _operation.Calculate(param1, param2);
        }
    }
}
