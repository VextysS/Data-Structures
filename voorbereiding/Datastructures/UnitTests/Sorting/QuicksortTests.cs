using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting.Tests
{
    [TestClass()]
    public class QuicksortTests
    {
        [TestMethod()]
        public void SortComparerDoubleTest()
        {
            double[] input = [5, 2, 9, 1, 5, 6];
            double[] expected = [1, 2, 5, 5, 6, 9];

            //Act
            Quicksort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }

        [TestMethod()]
        public void SortComparerIntTest()
        {
            int[] input = [5, 2, 9, 1, 5, 6];
            int[] expected = [1, 2, 5, 5, 6, 9];

            //Act
            Quicksort.Sort(input);

            CollectionAssert.AreEqual(expected, input);
        }
    }
}