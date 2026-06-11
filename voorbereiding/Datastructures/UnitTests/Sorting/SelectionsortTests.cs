using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting.Tests
{
    [TestClass]
    public class SelectionsortTests
    {
        [TestMethod]
        public void Selectionsort_SortsArrayInAscendingOrder()
        {
            //ARRANGE
            int[] input = [5, 1, 3, 2, 4];
            int[] expected = [5, 4, 3, 2, 1];
            //ACT
            Selectionsort.Sort(input);
            //ASSERT
            CollectionAssert.AreEqual(expected, input);
        }
    }
}