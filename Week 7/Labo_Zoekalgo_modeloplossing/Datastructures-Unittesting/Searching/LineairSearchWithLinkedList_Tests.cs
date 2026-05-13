using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.LineairStructures.SLL;
using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class LineairSearchWithLinkedList_Tests
    {
        [TestMethod]
        public void TestItemFoundFirstOccurance()
        {
            LinkedList list = new LinkedList();
            string find = "WOORD6";
            for (int i = 0; i < 10; i++)
                list.AddLast($"WOORD{i}");

            var node = LineairSearch.Find(list, find);

            Assert.IsNotNull(node);
            Assert.AreEqual(find, node.Value);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
            LinkedList list = new LinkedList();
            string find = "WOORD11";
            for (int i = 0; i < 10; i++)
                list.AddLast($"WOORD{i}");

            var node = LineairSearch.Find(list, find);

            Assert.IsNull(node);
        }

        [TestMethod]
        public void TestItemFoundSecondOccurance()
        {
            LinkedList list = new LinkedList();
            string find = "WOORD6";
            for (int i = 0; i < 10; i++)
                list.AddLast($"WOORD{i}");
            for (int i = 0; i < 10; i++)
                list.AddLast($"WOORD{i}");

            var node = LineairSearch.Find(list, find, 2);

            Assert.IsNotNull(node);
            Assert.AreEqual(find, node.Value);
        }

        [TestMethod]
        public void TestItemNotFoundSecondOccurance()
        {
            LinkedList list = new LinkedList();
            string find = "WOORD6";
            for (int i = 0; i < 10; i++)
                list.AddLast($"WOORD{i}");

            var node = LineairSearch.Find(list, find, 2);

            Assert.IsNull(node);
        }
    }
}
