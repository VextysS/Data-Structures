

using ClassLibrary.LineairStructures;

namespace UnitTests;

[TestClass]
public class Stack_tests
{
    [TestMethod]
    public void TestStack()
    {
        int[] list = new int[] { 100, 20, 80, 44, 1 };
        Stack s = new Stack(5);

        Assert.IsTrue(s.Count() == 0);

        foreach (int i in list)
        {
            s.Push(i);
        }
        
        Assert.IsTrue(s.Count() == 5);

        for (int i = list.Length - 1; i >= 0; i--)
        {
            Assert.AreEqual(list[i], s.Pop());
        }

        Assert.IsTrue(s.Count() == 0);
        //TODO: first check if stack is empty
        //TODO: then add each item in list to the stack
        //TODO: check if stack now contains 5 items (without removing them)
        //TODO: get all items from the stack again and compare if they are in the reversed order as the list above
        //TODO: check if stack is now empty
    }
}
