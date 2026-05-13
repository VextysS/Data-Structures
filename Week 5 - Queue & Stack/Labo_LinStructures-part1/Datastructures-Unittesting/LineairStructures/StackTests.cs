using System;
using Datastructures_ClassLibrary.LineairStructures;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datastructures_ClassLibrary.Helpers;

namespace Datastructures_Unittesting.LineairStructures
{
    [TestClass]
    public class Stack_tests
    {
        [TestMethod]
        public void TestStack()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1 };
            Stack s = new Stack();

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.IsFalse(s.IsEmpty);
            Assert.AreEqual(list.Length, s.Count);

            int index = list.Length - 1;
            while (s.Count > 0)
            {
                Assert.AreEqual(list[index], s.Pop());
                index--;
            }

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);
        }

        [TestMethod]
        public void TestStackWith11Elements()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1, 101, 102, 103, 104, 105 };
            Stack s = new Stack();

            //first fill up the Queue with 10 values
            for (int i = 0; i < list.Length; i++)
            {
                s.Push(list[i]);
            }

            //No try to add an extra value to the queue
            try
            {
                //This call should throw an Exception
                s.Push(100);
                Assert.Fail();  //Let the test fail, if no Exception was thrown!
            }
            catch (Exception e)
            {
                //Test was success full !
            }
        }

        [TestMethod]
        public void TestStackAddElementsWhileNotIsFull()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1, 101, 102, 103, 104, 105, 106, 110 };
            Stack s = new Stack();

            int counter = 0;
            while (!s.IsFull)
            {
                s.Push(list[counter]);
                counter++;
            }

            Assert.AreEqual(counter, s.Count);

            counter = s.Count - 1;
            while (s.Count > 0)
            {
                Assert.AreEqual(list[counter], s.Pop());
                counter--;
            }

            Assert.AreEqual(0, s.Count);
        }

        [TestMethod]
        public void TestStackPopFromEmptyStack()
        {
            Stack s = new Stack();
            try
            {
                s.Pop();
                Assert.Fail();
            }
            catch (Exception)
            {
                //Test was successfull
            }
        }

        [TestMethod]
        public void TestStackWithCapacity100()
        {
            Stack s = new Stack(100);
            Assert.AreEqual(100, s.Capacity);
        }


        [TestMethod]
        public void TestStackWithCapacity500()
        {
            int capa = 500;
            Stack s = new Stack(capa);
            Assert.AreEqual(capa, s.Capacity);

            int[] list = RandomArrayGenerator.Generate(capa, 0, 100000);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.AreEqual(list.Length, s.Count);

            int index = list.Length - 1;
            while (!s.IsEmpty)
            {
                Assert.AreEqual(list[index], s.Pop());
                index--;
            }
        }

        [TestMethod]
        public void TestCanGrowStackWith21Elements()
        {
            Stack s = new Stack(10, true);
            int[] list = RandomArrayGenerator.Generate(21, 0, 50);
            Assert.AreEqual(10, s.Capacity);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.AreEqual(list.Length, s.Count);
            Assert.AreEqual(40, s.Capacity); // Expected capa: 10 * 2 * 2

            int index = list.Length - 1;
            while (!s.IsEmpty)
            {
                Assert.AreEqual(list[index--], s.Pop());
            }

            //Capacity stays the same, even if empty
            Assert.AreEqual(40, s.Capacity); // Expected capa: 10 * 2 * 2
        }

        [TestMethod]
        public void TestPeekWithPushAndPop()
        {
            Stack s = new Stack();
            s.Push(45);
            Assert.AreEqual(45, s.Peek());
            s.Push(99);
            Assert.AreEqual(99, s.Peek());
            s.Pop();
            Assert.AreEqual(45, s.Peek());
        }


        [TestMethod]
        public void TestPeekWithEmptyStack()
        {
            Stack s = new Stack();

            try
            {
                s.Peek();
                Assert.Fail();
            }
            catch (Exception)
            {
                //Ok an exception was thrown !
            }
        }

    }
}
