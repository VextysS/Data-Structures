using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting
{
    public class Selectionsort
    {
        public static void Sort(int[] input)
        {
            int kleinsteIndext = 0;

            //Eerste iteratie, kleinsteIndext = 0 en j = 1
            //als kleinsteIndext > j -> wissel om

            //Eerste iteratie, kleinsteIndext = 1 en j = 2
            //etc,

            for (global::System.Int32 i = 0; i < input.Length - 1; i++)
            {
                kleinsteIndext = i;
                for (global::System.Int32 j = i + 1; j < input.Length; j++)
                {
                    if (input[kleinsteIndext] > input[j])
                    {
                        kleinsteIndext = j;
                    }
                }
                if (kleinsteIndext != i)
                {
                    int temp = input[i];
                    input[i] = input[kleinsteIndext];
                    input[kleinsteIndext] = temp;
                }
            }
        }

        public static void Sort(string[] input)
        {
            int kleinsteIndex = 0;
            for (int i = 0; i < input.Length -1; i++)
            {
                kleinsteIndex = i;
                for (global::System.Int32 j = 0; j < input.Length; j++)
                {
                    /*
                     returns < 0 → a comes before b
                     returns 0 → they are equal
                     returns > 0 → a comes after b
                    */
                    if (String.Compare(input[j], input[kleinsteIndex]) < 0)
                    {
                        kleinsteIndex = j;
                    }
                }

                if(kleinsteIndex != i)
                {
                    string temp = input[kleinsteIndex];
                    input[kleinsteIndex] = input[i];
                    input[i] = temp;
                }
            }
        }
    }
}
