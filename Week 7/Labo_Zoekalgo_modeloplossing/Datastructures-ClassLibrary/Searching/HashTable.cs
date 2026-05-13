using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Searching
{
    /// <summary>
    /// Basic Hashtable without linked list
    /// So 2 items with the same hash cannot be stored in this list.
    /// (An exception will be thrown)
    /// </summary>
    public class Hashtable
    {
        private string[] array;

        public Hashtable(int size)
        {
            array = new string[size]; 
        }

        public void AddItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] != null)
                throw new Exception("The item cannot be added to the table");
            array[idx] = text;
        }

        public int FindItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == text)
                return idx;

            return -1;
        }

        private int CalcIndex(string text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }
    }
}
