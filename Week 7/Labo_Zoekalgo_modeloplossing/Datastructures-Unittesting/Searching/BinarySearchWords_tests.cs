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
    public class BinarySearchWords_tests
    {
        [TestMethod]
        public void TestList()
        {
            //several words with same length
            string[] list = ["Ploeg", "Kat", "Blokken", "Voorraad", "Boom", "Ei", "Dak", "Mens", "Varen", "Schemer"];
            //this insertion sort will use a Comparer method.
            //this comparer will determine the sort order (in this case, sort by length and then alphabetically)
            Insertionsort.Sort(list);

            var randomIndex = new Random().Next(list.Length);

            //Now wil use the binary search to Search in that ordered list.
            //The binary search will use the same Comparer
            int index = BinarySearch.Find(list, list[randomIndex]);

            Assert.AreEqual(randomIndex, index);
        }
    }
}
