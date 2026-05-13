using System;
using Datastructures_ClassLibrary.Sorting;

namespace Datastructures_Unittesting.Sorting;

[TestClass]
public class SelectionsortString_tests
{
    [TestMethod]
    public void TestWordSordInAlphabeticalOrder()
    {
        string[] list = ["Appel", "Peer", "Citroen", "Banaan", "Kiwi"];

        Selectionsort.Sort(list);

        for (int i = 0; i < list.Length-1; i++)
        {
            Assert.IsTrue(String.Compare(list[i], list[i+1]) <= 0);
        }
    }
}
