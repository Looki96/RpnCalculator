using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class SubtractionOperator : BinaryOperator
    {
        private static String MINUS = "-";

        protected override int DoOperation(int lhs, int rhs)
        {
            return lhs - rhs;
        }

        public override bool HandlesOperatorCharacter(String operand)
        {
            return MINUS.Equals(operand);
        }
    }
}
