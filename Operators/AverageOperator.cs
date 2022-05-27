using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class AverageOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int runningTotal = 0;
            int runningCount = 0;
            while (!numbers.isEmpty())
            {
                runningCount++;
                runningTotal += numbers.pop();
            }
            int ave = 0;
            if (runningCount > 0)
            {
                ave = runningTotal / runningCount;
            }
            numbers.push(ave);
            return ave;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return "AVERAGE".Equals(operand.ToUpper()) || "AVE".Equals(operand.ToUpper());

        }
    }
}
