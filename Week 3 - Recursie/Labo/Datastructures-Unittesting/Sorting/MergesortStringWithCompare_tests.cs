using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Sorting
{
    [TestClass]
    public class MergesortStringWithCompare_tests
    {
        [TestMethod]
        public void TestWordSortByLengthAndAlphabeticalAscending()
        {
            //No 2 words are identical in length, so no alphabetical ordering is done here
            string[] list = ["Status", "Peer", "Citroen", "A", "Het"];

            Mergesort.Sort(list);

            for (int i = 0; i < list.Length - 1; i++)
            {
                Assert.IsTrue(list[i].Length <= list[i + 1].Length);
            }
        }

        [TestMethod]
        public void TestDuplicateWordSortByLengthAscending()
        {
            //several words with same length
            string[] list = ["Ploeg", "Kat", "Blokken", "Voorraad", "Boom", "Ei",  "Dak", "Mens",  "Varen", "Schemer"];

            Mergesort.Sort(list);

            int sameLengthCounter = 0;
            for (int i = 0; i < list.Length - 1; i++)
            {
                Assert.IsTrue(list[i].Length <= list[i + 1].Length);
                if (list[i].Length == list[i+1].Length)
                {
                    sameLengthCounter++;
                    //Same length elements must be alphabetically ordered
                    Assert.IsTrue(string.Compare(list[i], list[i + 1]) < 0);
                }
                
                
            }
            //Check if 3 duplicate length combinations were found
            //kat&dak / boom&Mens / ploeg&varen / schemer/blokken
            Assert.AreEqual(4, sameLengthCounter);
        }

    }
}
