using ClassLibrary.LineairStructures.SLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.LineairStructures.SSL
{
    [TestClass]
    public class QueueString_SLL_Tests
    {
        [TestMethod]
        public void TestQueue()
        {
            string[] list = new string[] { "hond", "auto", "boek", "muziek", "koffie" };
            QueueString q = new QueueString();
            Assert.AreEqual(0, q.Count);
            Assert.IsTrue(q.IsEmpty);

            for (int i = 0; i < list.Length; i++)
            {
                q.Enqueue(list[i]);
            }

            Assert.AreEqual(5, q.Count);
            Assert.IsFalse(q.IsEmpty);

            int count = 0;
            while (q.Count > 0)
            {
                Assert.AreEqual(list[count++], q.Dequeue());
            }
            Assert.AreEqual(0, q.Count);
            Assert.IsTrue(q.IsEmpty);
        }
    }
}
