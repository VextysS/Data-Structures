using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class Queue
    {
        private int[] data;
        private int RearIndex = -1;
        private readonly bool canGrow;

        public Queue(int capacity = 10, bool canGrow = false)
        {
            this.data = new int[capacity];
            this.canGrow = canGrow;
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
        public void Enqueue(int number)
		{
            if(IsFull)
            {
                if (canGrow)
                {
                    int[] temp = new int[data.Length * 2];
                    data.CopyTo(temp, 0);
                    data = temp;
                }
                else
                {
                    throw new Exception("De Queue is volzet");
                }
            }
            RearIndex++;
            data[RearIndex] = number;
        }

        public int Dequeue()
		{
            if (IsEmpty)
                throw new Exception("Queue is empty !");

            int temp = data[0];
            for (int i = 0; i < RearIndex; i++)
            {
                data[i] = data[i + 1];
            }
            RearIndex--;
            
            return temp;
        }
    }
}
