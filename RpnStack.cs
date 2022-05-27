using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class RpnStack
    {
        private Stack<int> stack;

        public RpnStack()
        {
            stack = new Stack<int>();
        }

        public void push(int n)
        {
            stack.Push(n);
        }

        public int pop()
        {
            int n;
            if (isEmpty())
                n = 0;
            else
                n = stack.Pop();
            return n;
        }

        public int peek()
        {
            int n;
            if (isEmpty())
            {
                n = 0;
            }
            else
            {
                n = stack.Peek();
            }
            return n;
        }

        public bool isEmpty()
        {
            return (stack.Count() == 0);
        }
    }
}
