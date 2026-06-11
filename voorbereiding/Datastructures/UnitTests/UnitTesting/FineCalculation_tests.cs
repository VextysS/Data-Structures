using Datastructures_ClassLibrary.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.UnitTesting
{
    [TestClass]
    public class FineCalculation_tests
    {
        [TestMethod]
        public void TestFineAtCorrectSpeedOutsideSchoolZone()
        {
            //1. Arrange: prepare everything for testing
            int actualSpeed = 27;
            int speedLimit = 30;
            int expectedFine = 0; // no fine is expected for this speed
            bool inSchoolZone = false;

            //2. Act: run the test
            int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

            //3. Assert: check the result of the test
            Assert.AreEqual(expectedFine, actualFine);
        }

        [TestMethod]
        public void TestFineLessThan10kmhTooFastOutsideSchoolzone()
        {
            //Arrange
            //FineCalculation newCalculation = new FineCalculation();

            //Act
            int speed = 29;
            int speedLimit = 20;
            bool inSchoolZone = false;
            int boeteCalculate = FineCalculation.CalculateFine(speed, speedLimit, inSchoolZone);
            //assert
            Assert.AreEqual(50, 50);
        }

        [TestMethod]
        public void TestFineLessThan20kmhTooFastOutsideSchoolzone()
        {
            //TODO: write here your test (base on the previous test)
            Assert.Fail(); // remove this line when you start working on this test
        }

        [DataTestMethod]
        [DataRow(51)]
        [DataRow(56)]
        [DataRow(60)]
        [DataRow(99)]
        public void TestFineMoreThan20kmhTooFastOutsideSchoolzone(int actualSpeed)
        {
            //TODO: write here your test (base on the previous test)
            //from here we will work with a DataTestMethod
            //this means that we can run the same test for several different speeds
            //with the same speedLimit
            int speedLimit = 30;
            //...
            Assert.Fail(); // remove this line when you start working on this test
        }

        [DataTestMethod]
        public void TestFineCorrectSpeedInsideSchoolzone(int actualSpeed)
        {
            bool inSchoolZone = true;
            //TODO: write here your test (base on the previous test)
            //Add your own datarows and choose an appropriate speedLimit
            Assert.Fail(); // remove this line when you start working on this test
        }

        [TestMethod]
        [DataRow(31, 30)]
        [DataRow(38, 30)]
        [DataRow(53, 50)]
        [DataRow(75, 70)]
        [DataRow(79, 70)]
        public void TestFineLessThan10kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
        {
            //TODO: write here your test (base on the previous test)
            //With this DataTest we can run the test with different combinations of speeds and speedLimits !
            Assert.Fail(); // remove this line when you start working on this test    
        }

        [DataTestMethod]
        public void TestFineLessThan20kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
        {
            //TODO: write here your test (base on the previous test)
            Assert.Fail(); // remove this line when you start working on this test    
        }

        [DataTestMethod]
        public void TestFineMoreThan20kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
        {
            Assert.Fail(); // remove this line when you start working on this test    
        }

        [DataTestMethod]
        [DataRow()]
        public void TestFineWithDifferentSpeedsLimitsAndFinesInSchoolZone(int actualSpeed, int speedLimit, int expectedFine)
        {
            //TODO: for this final test we are going to test several combinations of speeds and limits
            //and expectedFines. So this test could actually replace a lot of the previous tests
            //only 1 parameter is missing to replace all of the above tests, which one ?
            //create an extra DataTestMethod for this
            Assert.Fail(); // remove this line when you start working on this test    
        }
    }
}
