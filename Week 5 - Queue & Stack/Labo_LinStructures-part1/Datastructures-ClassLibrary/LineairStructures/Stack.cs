using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class Stack<T>
    {
        private T[] data;
        private int top = -1;

        public Stack(int initialCapacity = 10)
        {
            data = new T[initialCapacity];
        }

        public int Count
        {
            get { return top + 1; }
        }

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
            get { return this.top < 0; }
        }

        public void Push(T item)
        {
            if (IsFull)
            {
                T[] temp = new T[data.Length * 2];
                data.CopyTo(temp, 0);
                data = temp;
            }
            
            top++;
            data[top] = item;
        }

        public T Pop()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty !");
            }
            
            T temp = data[top];
            top--;

            return temp;
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new Exception("Stack is empty !");
            }
            return data[top];
        }
    }
}
