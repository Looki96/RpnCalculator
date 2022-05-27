using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class MultiplicationOperator : BinaryOperator
    {
        private static String MULTIPLY = "*";

        protected override int DoOperation(int lhs, int rhs)
        {
            return lhs * rhs;
        }

        public override bool HandlesOperatorCharacter(String operand)
        {
            return MULTIPLY.Equals(operand);
        }
    }
}
