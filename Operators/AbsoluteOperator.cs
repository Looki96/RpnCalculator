using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class AbsoluteOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int n = numbers.pop();
            int result = GetAbsolute(n);
            numbers.push(result);
            return result;
        }

        private int GetAbsolute(int n)
        {
            int result;
            if (n > 0)
                result = n;
            else if (n < 0)
                result = -1 * n;
            else
                result = n;
            return result;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return operand.Equals("||");
        }
    }
}
