using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class QueueString
    {
        private string[] data;
        private int RearIndex = -1;
        private readonly bool canGrow;

        public QueueString(int capacity = 10, bool canGrow = false)
        {
            this.data = new string[capacity];
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
            get { return this.Count == this.Capacity; }
        }

        public bool IsEmpty
        {
            get { return this.RearIndex < 0; }
        }

        public void Enqueue(string item)
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
                {
                    throw new Exception("De Queue is volzet");
                }
            }

            RearIndex++;
            data[RearIndex] = item;

        }

        public string Dequeue()
        {
            if (IsEmpty)
            {
                throw new Exception("De Queue is leeg");
            }

            string temp = data[0];
            for (int i = 0; i < RearIndex; i++)
            {
                data[i] = data[i + 1];
            }
            RearIndex--;
            return temp;
        }
    }
}
