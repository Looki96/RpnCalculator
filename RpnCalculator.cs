using Calculator.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RpnCalculator
    {
        private RpnStack numbers = new RpnStack();
        private OperatorRegistry operatorRegistry = new OperatorRegistry();

        public void enter(int operand)
        {
            numbers.push(operand);
        }

        public int perform(String operatorCharacter)
        {
            int result = 0;
            IOperator operatorImplementation = operatorRegistry.GetOperator(operatorCharacter);
            if (operatorImplementation == null) throw new ArgumentException("Unknown Operator " + operatorCharacter);
            result = operatorImplementation.DoOperation(numbers);
            return result;
        }

        public int peek()
        {
            return numbers.peek();
        }
    }
}
