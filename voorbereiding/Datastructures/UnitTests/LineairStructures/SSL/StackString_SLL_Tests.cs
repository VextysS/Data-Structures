using ClassLibrary.LineairStructures.SLL;

namespace UnitTests;

[TestClass]
public class StackString_SLL_Tests
{
    [TestMethod]
    public void TestStack()
    {
        string[] list = new string[] { "hond", "auto", "boek", "muziek", "koffie" }; ;
        StackString s = new StackString();

        Assert.AreEqual(0, s.Count);
        Assert.IsTrue(s.IsEmpty);
        foreach (var item in list)
        {
            s.Push(item);
        }

        Assert.AreEqual(list.Length, s.Count);
        Assert.IsFalse(s.IsEmpty);

        int index = list.Length - 1;
        while (s.Count > 0)
        {
            Assert.AreEqual(list[index], s.Pop());
            index--;
        }
        Assert.AreEqual(0, s.Count);
        Assert.IsTrue(s.IsEmpty);
    }
}
