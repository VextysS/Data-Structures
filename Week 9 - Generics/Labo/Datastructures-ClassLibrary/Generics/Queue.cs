using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Generics
{
    public class Queue<T>
    {
        private T[] data;
        private int RearIndex = -1;

        public Queue(int capacity = 10)
        {
            data = new T[capacity];
        }

        public int Count
        {
            get { return RearIndex + 1; }
        }

        public int Capacity
        {
            get { return data.Length; }
        }

        public bool IsFull
        {
            get
            {
                //if (Count == Capacity)
                //    return true;
                //else
                //    return false;

                //=> shorter notation 
                return Count == Capacity;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return RearIndex == -1;
            }
        }
        public void Enqueue(T number)
        {
            if (IsFull)
            {
                    T[] temp = new T[data.Length * 2];
                    data.CopyTo(temp, 0);
                    data = temp;
            }
            RearIndex++;
            data[RearIndex] = number;
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new Exception("Queue is empty !");

            T temp = data[0];
            for (int i = 0; i < RearIndex; i++)
            {
                data[i] = data[i + 1];
            }
            RearIndex--;

            return temp;
        }
    }
}
