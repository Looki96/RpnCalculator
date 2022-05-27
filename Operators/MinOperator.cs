using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public class MinOperator : IOperator
    {
        public int DoOperation(RpnStack numbers)
        {
            int minValue;

            if (numbers.isEmpty())
            {
                minValue = 0;
            }
            else
            {
                minValue = numbers.pop();
            }

            while (!numbers.isEmpty())
            {
                int currentValue = numbers.pop();
                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }
            }

            numbers.push(minValue);
            return minValue;
        }

        public bool HandlesOperatorCharacter(String operand)
        {
            return operand.Equals("min");
        }
    }
}
