using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class ReverseOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            RpnStack tempStackA = new RpnStack();
            RpnStack tempStackB = new RpnStack();
            ReverseCopyStack(numbers, tempStackA);
            ReverseCopyStack(tempStackA, tempStackB);
            ReverseCopyStack(tempStackB, numbers);
            return numbers.peek();
        }

        private void ReverseCopyStack(RpnStack from, RpnStack to)
        {
            while (!from.isEmpty())
                to.push(from.pop());
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return "REVERSE".Equals(operand.ToUpper()) || "REV".Equals(operand.ToUpper());
        }
    }
}
