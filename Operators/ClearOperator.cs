using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class ClearOperator : IOperator
    {
        private static String C = "C";
        private static String CLEAR = "CLEAR";

        public int DoOperation(RpnStack numbers)
        {
            while (!numbers.isEmpty())
                numbers.pop();
            return 0;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return C.Equals(operand.ToUpper()) || CLEAR.Equals(operand.ToUpper());

        }
    }
}
