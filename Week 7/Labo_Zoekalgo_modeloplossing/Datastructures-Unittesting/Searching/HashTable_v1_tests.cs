using Datastructures_ClassLibrary.Searching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_Unittesting.Searching
{
    [TestClass]
    public class HashTable_v1_tests
    {
        [TestMethod]
        public void TestAddAndFindItem()
        {
            Hashtable ht = new Hashtable(10);
            
            string find = "WOORD2";
            for (int i = 0; i < 3; i++)
                ht.AddItem($"WOORD{i}");

            var index = ht.FindItem(find);

            Assert.IsTrue(index > 0);
        }


        [TestMethod]
        public void TestAddWithCollision()
        {
            Hashtable ht = new Hashtable(10);

            try
            {
                //try adding 30 words to a list with a capacity of 10 words.
                //A collission should always occur here.
                for (int i = 0; i < 30; i++)
                    ht.AddItem($"WOORD{i}");
                //No collision detected ? This is not possible
                Assert.Fail();
            }
            catch(Exception)
            {
                
            }
        }
    }
}
