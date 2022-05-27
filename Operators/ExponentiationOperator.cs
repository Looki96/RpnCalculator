using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class ExponentiationOperator : BinaryOperator
    {
        private static String POWER = "^";

        protected override int DoOperation(int lhs, int rhs)
        {
            int product = 1;
            if (rhs > 0)
                for (int i = 0; i < rhs; i++)
                    product = product * lhs;
            else if (rhs < 0)
                product = 1 / DoOperation(lhs, -1 * rhs);
            return product;
        }

        public override bool HandlesOperatorCharacter(String operand)
        {
            return POWER.Equals(operand);
        }
    }
}
