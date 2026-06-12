using Datastructures_ClassLibrary.LineairStructures;
using System;

namespace Datastructures_ClassLibrary.Recursion;

public class TextHelpers
{
    public static int CalculateWordLength(string word)
    {
        if (string.IsNullOrEmpty(word)) // word == null || word == ""
        {
            return 0;
        }
        //remove the first letter and calculate the length of the remaining word
        //then add 1 to that length
        int length = CalculateWordLength(word.Substring(1)) + 1;
        return length;
    }


    public static string ReverseText(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            //If text is "", we return "", if text == null we return null
            return text;
        }
        return ReverseText(text.Substring(1)) + text[0];
    }
    
    public static void ReverseTextWithQueue(string text, QueueString queue)
    {
        if(string.IsNullOrEmpty(text))
        {
            return;
        }

        ReverseTextWithQueue(text.Substring(1), queue);
        queue.Enqueue(text[0].ToString());
    }



    public static List<char> SplitString(string text)
    {
        List<char> list = new List<char>();
        SplitString(text, list);
        return list;
    }

    private static void SplitString(string text, List<char> list)
    {
        if (string.IsNullOrEmpty(text))
        {
            return;
        }
        list.Add(text[0]);
        SplitString(text.Substring(1), list);
    }


    //Deze methode komt uit de oefeningen: Lineaire structuren deel 1
    public static string ReverseText(string text, QueueString queue)
    {
        if (string.IsNullOrEmpty(text))
        {
            //If text is "", we return "", if text == null we return null
            return text;
        }
        return ReverseText(text.Substring(1), queue) + text[0];
    }

}
