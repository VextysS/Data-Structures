


using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.LineairStructures;

namespace Datastructures_Unittesting.LineairStructures
{
    [TestClass]
    public class Queue_tests
    {
        [TestMethod]
        public void TestQueue()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1 };
            Queue q = new Queue();

            Assert.AreEqual(0, q.Count);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

           
            Assert.AreEqual(list.Length, q.Count);

            foreach (var item in list)
            {
                Assert.AreEqual(item, q.Dequeue());
            }

            Assert.AreEqual(0, q.Count);
        }




        [TestMethod]
        public void TestQueueWith11Elements()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1, 101, 102, 103, 104, 105 };
            Queue q = new Queue();

            //first fill up the Queue with 10 values
            for (int i = 0; i < list.Length; i++)
            {
                q.Enqueue(list[i]);
            }

            //No try to add an extra value to the queue
            try
            {
                //This call should throw an Exception
                q.Enqueue(100);
                Assert.Fail();  //Let the test fail, if no Exception was thrown!
            }
            catch (Exception e)
            {
                //Test was success full !
            }
        }

        [TestMethod]
        public void TestQueueAddElementsWhileNotIsFull()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1, 101, 102, 103, 104, 105, 106, 110 };
            Queue q = new Queue();

            int counter = 0;
            while (!q.IsFull)
            {
                q.Enqueue(list[counter]);
                counter++;
            }

            Assert.AreEqual(counter, q.Count);
            Assert.AreEqual(counter, q.Capacity);

            counter = 0;
            while (q.Count > 0)
            {
                Assert.AreEqual(list[counter], q.Dequeue());
                counter++;
            }

            Assert.AreEqual(0, q.Count);
        }

        [TestMethod]
        public void TestDequeueFromEmptyQueue()
        {
            Queue q = new Queue();
            try
            {
                q.Dequeue();
                Assert.Fail();
            }
            catch (Exception)
            {
                //Test was successfull
            }
        }

        [TestMethod]
        public void TestQueueWithCapacity100()
        {
            Queue q = new Queue(100);
            Assert.AreEqual(100, q.Capacity);
        }

        [TestMethod]
        public void TestQueueWithCapacity500()
        {
            int capa = 500;
            Queue q = new Queue(capa);
            Assert.AreEqual(capa, q.Capacity);

            int[] list = RandomArrayGenerator.Generate(capa, 0, 100000);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

            Assert.AreEqual(list.Length, q.Count);

            int index = 0;
            while (!q.IsEmpty)
            {
                Assert.AreEqual(list[index++], q.Dequeue());
            }
        }

        [TestMethod]
        public void TestCanGrowQueueWith21Elements()
        {
            Queue q = new Queue(10, true);
            int[] list = RandomArrayGenerator.Generate(21, 0, 50);
            Assert.AreEqual(10, q.Capacity);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

            Assert.AreEqual(list.Length, q.Count);
            Assert.AreEqual(40, q.Capacity); // Expected capa: 10 * 2 * 2

            int index = 0;
            while (!q.IsEmpty)
            {
                Assert.AreEqual(list[index++], q.Dequeue());
            }

            //Capacity stays the same, even if empty
            Assert.AreEqual(40, q.Capacity); // Expected capa: 10 * 2 * 2
        }


    }
}
