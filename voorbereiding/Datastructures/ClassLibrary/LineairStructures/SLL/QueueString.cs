using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.LineairStructures.SLL
{
    public class QueueString
    {
        private int count;
        private LinkedList<string> list = new LinkedList<string>();

        public int Count
        {
            get {
                 return list.Count;
            }
        }

        public bool IsEmpty
        {
            get {
                if (list.Count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Enqueue(string item)
        {
            list.AddLast(item);
        }

        public string Dequeue()
        {
            string temp = list.First();
            list.RemoveFirst();
            return temp;
        }
    }
}
