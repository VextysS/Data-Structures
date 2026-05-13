using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures.SLL
{
    public class LinkedList
    {
        public LinkedListNode First { get; private set; }
        public LinkedListNode Last { get; private set; }

        public bool IsEmpty
        {
            get
            {
                return First == null;
            }
        }

        public int Count { get; private set; }

        public LinkedListNode AddLast(string item)
        {
            var newNode = new LinkedListNode()
            {
                Value = item
            };

            if (Last != null)
            {
                Last.Next = newNode;
            }
            Last = newNode;

            if (First == null)
            {
                First = newNode;
            }
            Count++;
            return newNode;
        }   

        public LinkedListNode AddFirst(string item)
        {
            var newNode = new LinkedListNode()
            {
                Value = item
            };

            if (First != null)
            {
                newNode.Next = First;
            }
            First = newNode;

            if (Last == null)
            {
                Last = newNode;
            }
            Count++;
            return newNode;
        }

        public LinkedListNode AddAfter(LinkedListNode node, string item)
        {
            if (node == null)
                throw new ArgumentException("node is null");

            if(ReferenceEquals(node, Last))
            {
                return AddLast(item);
            }

            var newNode = new LinkedListNode()
            {
                Value = item
            };
            newNode.Next = node.Next;
            node.Next = newNode;
            Count++;
            return newNode;
        }

        public LinkedListNode AddBefore(LinkedListNode node, string item)
        {
            if (node == null)
                throw new ArgumentException("node is null");
            
            if (ReferenceEquals(node, First))
            {
                return AddFirst(item);
            }

            var newNode = new LinkedListNode()
            {
                Value = item
            };

            var previous = FindPrevious(node);
            if (previous != null)
            {
                newNode.Next = node;
                previous.Next = newNode;
            }
            Count++;
            return newNode;
        }

        public LinkedListNode Find(string item)
        {
            var temp = First;
            while (temp != null)
            {
                if (temp.Value == item)
                    return temp;
                temp = temp.Next;
            }
            return temp;
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
                throw new Exception("the list is empty");

            First = First.Next;
            //if there is no next node, then the list is empty now.
            if (First == null)
                Last = null;
            Count--;
        }

        #region private members
        /// <summary>
        /// With a SLL sometimes we have to travel through the list to find the previous node 
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        private LinkedListNode FindPrevious(LinkedListNode node)
        {
            LinkedListNode temp = First;

            if (ReferenceEquals(First, node))
                return null;  // there is no previous node

            while (temp != null && !ReferenceEquals(temp.Next, node))
                temp = temp.Next;

            return temp;
        }
        #endregion
    }
}
