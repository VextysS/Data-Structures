using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class TextHelpers
    {
        public static int CalculateWordLength(string word)
        {
            if (word == "") return 0;
            int length = CalculateWordLength(word.Substring(1)) + 1;
            return length;
            
        }
        public static List<char> SplitString(string word)
        {
            List<char> result = new List<char>();
            SplitString(word, result);
            return result;
        }

        private static void SplitString(string word, List<char> list)
        {
            if (string.IsNullOrEmpty(word)) return;
            list.Add(word[0]);
            SplitString(word.Substring(1), list);
        }
    }
}
