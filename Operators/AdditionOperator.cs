using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class AdditionOperator : BinaryOperator
    {
        private static String PLUS = "+";

        protected override int DoOperation(int lhs, int rhs)
        {
            return lhs + rhs;
        }

        public override bool HandlesOperatorCharacter(string operand)
        {
            return PLUS.Equals(operand);
        }
    }
}
