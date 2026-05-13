using Datastructures_ClassLibrary.LineairStructures.SLL;


namespace Datastructures_ClassLibrary.Searching
{
    public class LineairSearch
    {
        /// <summary>
        /// Find the specified value in the given list.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="list"></param>
        /// <returns>The index where the value was first found, or -1 if the value was not found</returns>
        public static int Find(int[] list, int value)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == value)
                    return i;
            }
            return -1;
        }


        /// <summary>
        /// Find the specified occurance for the specified value in the given list.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <param name="occurance">Can be used if the value is present more than once in the list</param>
        /// <returns>The node where the value was first found, or NULL if the value was not found</returns>
        public static LinkedListNode Find(LinkedList list, string value, int occurance = 1)
        {
            int count = 0;
            LinkedListNode node = list.First;
            while(node != null)
            {
                if (node.Value == value)
                {
                    count++;
                    if (count == occurance)
                        return node;
                }
                node = node.Next;
            }
            return null;
        }
    }
}
