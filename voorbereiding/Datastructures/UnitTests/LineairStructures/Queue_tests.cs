using ClassLibrary.LineairStructures;

namespace UnitTests;

[TestClass]
public class Queue_tests
{
    [TestMethod]
    public void TestQueue()
    {
        int[] list = new int[] { 100, 20, 80, 44, 1 };
        Queue q = new Queue(5);

        //TODO: first check if queue is empty
        if (q.Count() == 0)
        {
            for (int i = 0; i < list.Length; i++)
            {
                q.Enqueue(list[i]);
            }
        }
        if (q.Count() == 5) 
        { 
            for (int i = 0;i < list.Length;i++)
            {
                Assert.AreEqual(list[i], q.Dequeue());
            }
        }
        Assert.IsTrue(q.Count() == 0);
        //TODO: check if queue now contains 5 items (without removing them)
        //TODO: get all items from the queue again and compare if they are still in the same order as the list above
        //TODO: check if queue is now empty
    }

    [TestMethod()]
    public void CatchEmptyQeueueExectipn()
    {
        try
        {
            Queue q = new Queue(5);
            q.Dequeue();
        }
        catch (Exception)
        {

            //
        }
    }
}
