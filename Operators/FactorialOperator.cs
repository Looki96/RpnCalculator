using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class FactorialOperator : IOperator
    {
        private static String FACTORIAL = "!";

        public int DoOperation(RpnStack numbers)
        {
            int total = 1;
            int operand = numbers.pop();
            while (operand > 0)
            {
                total = total * operand;
                operand--;
            }
            numbers.push(total);
            return total;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return FACTORIAL.Equals(operand);
        }
    }
}
