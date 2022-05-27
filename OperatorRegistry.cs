using Calculator.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class OperatorRegistry
    {
        private List<IOperator> registry;

        public OperatorRegistry()
        {
            registry = GetRegistry();
        }

        private List<IOperator> GetRegistry()
        {
            List<IOperator> operatorRegistry;
            operatorRegistry = new List<IOperator>();
            operatorRegistry.Add(new AdditionOperator());
            operatorRegistry.Add(new SubtractionOperator());
            operatorRegistry.Add(new MultiplicationOperator());
            operatorRegistry.Add(new DivisionOperator());
            operatorRegistry.Add(new FactorialOperator());
            operatorRegistry.Add(new ReverseOperator());
            operatorRegistry.Add(new AverageOperator());
            operatorRegistry.Add(new ClearOperator());
            operatorRegistry.Add(new ExponentiationOperator());
            operatorRegistry.Add(new AbsoluteOperator());
            operatorRegistry.Add(new FibonacciOperator());
            operatorRegistry.Add(new DoubleOperator());
            operatorRegistry.Add(new MaxOperator());
            operatorRegistry.Add(new MinOperator());
            return operatorRegistry;
        }

        public IOperator GetOperator(String operatorCharacter)
        {
            IOperator relevantOperator = null;
            if (operatorCharacter != null && !operatorCharacter.Equals(""))
            {
                foreach(IOperator op in registry)
                {
                    if (op.HandlesOperatorCharacter(operatorCharacter))
                    {
                        relevantOperator = op;
                        break;
                    }
                }
            }
            
            return relevantOperator;
        }  
    }
}
