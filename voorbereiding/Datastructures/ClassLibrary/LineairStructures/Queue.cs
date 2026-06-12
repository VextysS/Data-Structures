using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.LineairStructures
{
    public class Queue
    {
        private int count;
        private int capacity;
        private int[] array;
        private int rearIndex = 0;

        public Queue(int capacity)
        {
            this.capacity = capacity;
            array = new int[capacity];
        }

        public int Count()
        {
            return rearIndex;
        }
        public int Capacity()
        {
            return capacity;
        }
        public void Enqueue(int item)
        {
            if (count == capacity) 
            {
                //Create bigger array
                int[] ArrayLengthDoubled = new int[array.Length * 2];
                //Copy the old values
                array.CopyTo(ArrayLengthDoubled, 0);
                //Replace old array
                array = ArrayLengthDoubled;
            }
            else
            {
                throw new Exception("Failed to enlarge the queue");
            }

            array[rearIndex] = item;
            rearIndex++;
        }

        public int Dequeue()
        {
            if(IsEmpty())
            {
                throw new Exception("Queue is empty");
            }
            int temp = array[0];

            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            rearIndex--;
            return temp;
        }

        public bool IsEmpty()
        {
            return rearIndex == 0;
        }
    }
}
