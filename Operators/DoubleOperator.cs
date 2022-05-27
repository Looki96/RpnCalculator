using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class DoubleOperator : IOperator
    {
        private static String DOUBLE = "double";

        public int DoOperation(RpnStack numbers)
        {
            int operand = numbers.pop();
            int result = operand * 2;
            numbers.push(result);
            return result;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return operand.Equals(DOUBLE);
        }
    }
}
