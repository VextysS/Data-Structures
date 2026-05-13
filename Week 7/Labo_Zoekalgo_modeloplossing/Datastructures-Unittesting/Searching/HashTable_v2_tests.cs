using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class HashTable_v2_tests
    {
        [TestMethod]
        public void TestAddAndFindItem()
        {
            //in this version, collisions do not exist anymore
            Hashtable_v2 ht = new Hashtable_v2(10);

            string find = "WOORD2";
            for (int i = 0; i < 30; i++)  //now it is possible to add more words than the size of the table..
                ht.AddItem($"WOORD{i}");

            var word  = ht.FindItem(find);

            Assert.IsNotNull(word);
        }
    }
}
