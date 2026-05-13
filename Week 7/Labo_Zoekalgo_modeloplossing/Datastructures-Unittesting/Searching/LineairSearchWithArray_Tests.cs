using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class LineairSearchWithArray_Tests
    {
        [TestMethod]
        public void TestItemFound()
        {
            int[] list = { 2, 5, 1, 29, 7 };

            int index = LineairSearch.Find(list, 29);

            Assert.AreEqual(3, index);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
            int[] list = { 2, 5, 1, 29, 7 };

            int index = LineairSearch.Find(list, 30);

            Assert.AreEqual(-1, index);
        }
        [TestMethod]
        public void TestLargeList()
        {
            int[] list = RandomArrayGenerator.Generate(100000, 0, 1000000000, true);

            int randomIndex = new Random().Next(list.Length);
            int foundindex = LineairSearch.Find(list, list[randomIndex]);

            Assert.AreEqual(randomIndex, foundindex);
        }
    }
}
