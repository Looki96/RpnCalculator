using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public abstract class BinaryOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int result;
            int rhs = numbers.pop();
            int lhs = numbers.pop();

            result = DoOperation(lhs, rhs);
            numbers.push(result);
            return result;
        }

        public abstract bool HandlesOperatorCharacter(String operand);

        protected abstract int DoOperation(int lhs, int rhs);
    }
}
