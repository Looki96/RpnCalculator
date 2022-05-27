using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class MaxOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int maxValue;

            if (numbers.isEmpty())
            {
                maxValue = 0;
            }
            else
            {
                maxValue = numbers.pop();
            }

            while (!numbers.isEmpty())
            {
                int currentValue = numbers.pop();
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            numbers.push(maxValue);
            return maxValue;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return operand.Equals("max");
        }
    }
}
