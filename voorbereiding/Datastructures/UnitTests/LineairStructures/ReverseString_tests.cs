using Datastructures_ClassLibrary.LineairStructures;
using Datastructures_ClassLibrary.Recursion;

namespace UnitTests;

[TestClass]
public class ReverseString_tests
{
    [TestMethod]
    public void TestSmallWord()
    {
        string word = "Huppeldepup";
        QueueString queue = new QueueString();

        TextHelpers.ReverseTextWithQueue(word, queue);

        int index = word.Length - 1; //Start at the end, because word should be reversed
        while (queue.Count > 0)
        {
            char c = queue.Dequeue()[0];
            Assert.AreEqual(word[index], c);
            index--;
        }
    }
}
