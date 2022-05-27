using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class DivisionOperator : BinaryOperator
    {
        private static String DIVIDE = "/";

        protected override int DoOperation(int lhs, int rhs)
        {
            return lhs / rhs;
        }

        public override bool HandlesOperatorCharacter(String operand)
        {
            return DIVIDE.Equals(operand);
        }
    }
}
