using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.NonLineairStructures
{
    public class BSTNode
    {
        public BSTNode(int value)
        {
            Value = value;
        }

        public int Value { get; set; }

        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
