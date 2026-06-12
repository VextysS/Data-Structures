using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.LineairStructures
{
    public class Stack
    {
        private int count;
        private int capacity;
        private int[] array;
        private int top = 0;

        public Stack(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
        }

        public int Count()
        {
            /*int temp = 0;
            foreach (int i in array)
            {
                if (i != 0)
                {
                    temp++;
                }
            }

            return temp;*/
            return top;
        }
        public int Capacity() 
        {
            return capacity;
        }

        public void Push(int value) 
        {
            array[top] = value;
            top++;
        }

        public int Pop()
        {
            top--;
            int temp = array[top];
            array[top] = 0;
            return temp;
        }

        public int Peek()
        {
            return array[top];
        }

    }
}
