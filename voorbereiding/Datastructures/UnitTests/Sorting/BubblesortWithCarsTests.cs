using ClassLibrary.LineairStructures.SLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Examen_voorbereiding.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Helpers;
using Examen_voorbereiding.Helpers;

namespace BubblesortWithCars.Tests
{
    [TestClass()]
    public class BubblesortWithCarsTests
    {
        [TestMethod()]
        public void SortTest()
        {
            Car[] cars = RandomArrayGenerator.GenerateCars(100);

            Bubblesort.Sort(cars);

            //assert
            for (int i = 0; i < cars.Length - 1; i++)
            {
                Assert.IsTrue(cars[i].Year >= cars[i + 1].Year);
                if (cars[i].Year == cars[i + 1].Year)
                {
                    Assert.IsTrue(cars[i].Kilometers <= cars[i + 1].Kilometers);
                }
            }
        }

        
    }
}