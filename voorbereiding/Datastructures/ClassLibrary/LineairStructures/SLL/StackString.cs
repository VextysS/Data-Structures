using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.LineairStructures.SLL
{
    public class StackString
    {
        private LinkedList<string> stack = new LinkedList<string>();
        public int Count
        {
            get { return stack.Count; }
        }

        public bool IsEmpty
        {
            get 
            { 
                if (stack.Count == 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        public void Push(string item)
        {
            stack.AddLast(item);
        }

        public string Pop()
        {
            string temp = stack.Last();
            stack.RemoveLast();
            return temp;
        }

        public string Peek()
        {
            return stack.Last();
        }
    }
}
