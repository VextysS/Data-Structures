using Datastructures_ClassLibrary.LineairStructures.SLL;
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
    public class Hashtable_v2
    {
        private LinkedList[] array;

        public Hashtable_v2(int size)
        {
            array = new LinkedList[size]; 
        }

        public void AddItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == null)
                array[idx] = new LinkedList();  //make sure that the LL is created

            array[idx].AddLast(text);
        }

        public string FindItem(string text)
        {
            var idx = CalcIndex(text);
            if (array[idx] == null)
                array[idx] = new LinkedList(); //make sure that the LL is created

            if (array[idx].Find(text) != null)
                return text;

            return null;
        }

        private int CalcIndex(string text)
        {
            return Math.Abs(text.GetHashCode()) % array.Length;
        }
    }
}
