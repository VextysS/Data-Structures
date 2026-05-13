using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Searching;
using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class BinarySearchIntegers_Tests
    {
        [TestMethod]
        public void TestItemFound()
        {
            int[] list = { 1, 2, 5, 7, 29 };

            int index = BinarySearch.Find(list, 29);

            Assert.AreEqual(4, index);
        }

        [TestMethod]
        public void TestItemNotFound()
        {
            int[] list = { 1, 2, 5, 7, 29 };

            int index = BinarySearch.Find(list, 30);

            Assert.AreEqual(-1, index);
        }
        [TestMethod]
        public void TestLargeList()
        {
            int[] list = RandomArrayGenerator.Generate(100000, 0, 1000000000, true);

            int randomIndex = new Random().Next(list.Length);

            Quicksort.Sort(list);

            int foundindex = BinarySearch.Find(list, list[randomIndex]);

            Assert.AreEqual(randomIndex, foundindex);
        }
    }
}
