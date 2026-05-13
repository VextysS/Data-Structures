using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures.SLL
{
    public class LinkedListNode
    {
        public string Value { get; set; }

        public LinkedListNode Next { get; internal set; }
    }
}
