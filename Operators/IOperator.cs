using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operators
{
    public interface IOperator
    {
        int DoOperation(RpnStack numbers);
        bool HandlesOperatorCharacter(String operand);
    }
}
