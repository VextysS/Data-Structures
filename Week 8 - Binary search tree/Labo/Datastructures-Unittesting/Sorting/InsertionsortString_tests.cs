using System;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class InsertionsortString_tests
{
    [TestMethod]
    public void TestWordSortByLengthAscending()
    {
        string[] list = ["Status", "Peer", "Citroen", "A", "Het"];

        Insertionsort.Sort(list);

        for (int i = 0; i < list.Length-1; i++)
        {
            Assert.IsTrue(list[i].Length <= list[i+1].Length);
        }
    }

    [TestMethod]
    public void TestDuplicateWordSortByLengthAscending()
    {
        //several words with same length
        string[] list = ["Status", "Peer", "Citroen", "A", "Het", "Kiwi", "Een", "Banaan"];

        Insertionsort.Sort(list);

        for (int i = 0; i < list.Length - 1; i++)
        {
            Assert.IsTrue(list[i].Length <= list[i + 1].Length);
        }
    }
}
