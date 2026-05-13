using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.LineairStructures
{
    public class StackMath
    {
        public static bool EvaluateFormula(string formula)
        {
            StackString s = new StackString();
            foreach (var c in formula)
            {
                if (c == '(' || c == '[')
                {
                    s.Push(c.ToString());
                } 
                else if (c == ')' || c == ']')
                {
                    if (s.IsEmpty)
                        return false;
                    string p = s.Pop();
                    //extra for second version with 2 types: ( and [
                    if (p == "(" && c != ')')
                        return false;
                    if (p == "[" && c != ']')
                        return false;
                }
            }

            return s.IsEmpty; // if stack is empty, formula is valid !
        }
    }
}
