using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class FibonacciOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int n = numbers.pop();
            return fib(n);
        }

        private int fib(int n)
        {

            if (n <= 0)
                return 0;
            if (n == 1)
                return 1;

            int prev1 = 1;
            int prev2 = 0;
            int result = 0;

            for (int i = 1; i < n; i++)
            {
                result = prev1 + prev2;
                prev2 = prev1;
                prev1 = result;
            }

            return result;

        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return "FIB".Equals(operand.ToUpper()) || "FIBONACCI".Equals(operand.ToUpper());
        }
    }
}
