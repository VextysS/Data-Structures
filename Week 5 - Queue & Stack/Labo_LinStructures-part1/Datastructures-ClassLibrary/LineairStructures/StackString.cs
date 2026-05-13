using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class StackString
    {
        private string[] data;
        private int Top = -1;
        private int count;

        public StackString(int initialCapacity = 10, bool canGrow = false)
        {
            data = new string[initialCapacity];
            this.canGrow = canGrow;
        }
        public int Count
        {
            get { return Top + 1; }
        }

        private int capacity;
        private readonly bool canGrow;

        public int Capacity
        {
            get { return data.Length; }
        }

        public bool IsFull
        {
            get { return this.Count == this.Capacity; }
        }

        public bool IsEmpty
        {
            get { return this.Top < 0; }
        }

        public void Push(string item)
        {
            if (IsFull)
            {
                if (canGrow)
                {
                    string[] temp = new string[data.Length * 2];
                    data.CopyTo(temp, 0);
                    data = temp;
                }
                else
                    throw new Exception("Stack is full !");
            }
            Top++;
            data[Top] = item;
        }

        public string Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty !");
            }
            string temp = data[Top];
            Top--;

            return temp;
        }

        public string Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty !");
            }
            return data[Top];
        }
    }
}
