using System;

namespace Datastructures_Unittesting.unittesting;

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

        //Assert.AreEqual() vervangt onderstaande: if + Assert.Fail
        // if (actualFine == 0)
        // {
        //     //De correcte boete, test is gelukt !
        // }
        // else
        // {
        //     //berekening is niet correct gebeurd, test moet falen !
        //     Assert.Fail();
        // }
    }

    [TestMethod]
    public void TestFineLessThan10kmhTooFastOutsideSchoolzone()
    {
        //1. Arrange: prepare everything for testing
        int actualSpeed = 37;
        int speedLimit = 30;
        int expectedFine = 50; // fine of 50€ is expected for this test
        bool inSchoolZone = false;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);

    }

    [TestMethod]
    public void TestFineLessThan20kmhTooFastOutsideSchoolzone()
    {
        //1. Arrange: prepare everything for testing
        int actualSpeed = 65;
        int speedLimit = 50;
        int expectedFine = 100; // fine of 100€ is expected for this test
        bool inSchoolZone = false;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(51)]
    [DataRow(56)]
    [DataRow(60)]
    [DataRow(99)]
    public void TestFineMoreThan20kmhTooFastOutsideSchoolzone(int actualSpeed)
    {
        //1. Arrange: prepare everything for testing
        //int actualSpeed = 65; // this is now a parameter
        int speedLimit = 30;
        int expectedFine = 200; // fine of 200€ is expected for this test
        bool inSchoolZone = false;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(5)]
    [DataRow(12)]
    [DataRow(29)]
    [DataRow(30)]
    public void TestFineCorrectSpeedInsideSchoolzone(int actualSpeed)
    {
        //1. Arrange: prepare everything for testing
        int speedLimit = 30;
        int expectedFine = 0; // fine of 0€ is expected for this test
        bool inSchoolZone = true;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [TestMethod]
    [DataRow(31, 30)]
    [DataRow(38, 30)]
    [DataRow(53, 50)]
    [DataRow(75, 70)]
    [DataRow(79, 70)]
    public void TestFineLessThan10kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
    {
        //1. Arrange: prepare everything for testing
        //int speedLimit = 30;  //This is now also a parameter
        int expectedFine = 100; // fine of 100€ is expected for this test
        bool inSchoolZone = true;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(40, 30)]
    [DataRow(45, 30)]
    [DataRow(69, 50)]
    [DataRow(82, 70)]
    [DataRow(88, 70)]
    public void TestFineLessThan20kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
    {
        //1. Arrange: prepare everything for testing
        //int speedLimit = 30;  //This is now also a parameter
        int expectedFine = 150; // fine of 150€ is expected for this test
        bool inSchoolZone = true;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(50, 30)]
    [DataRow(65, 30)]
    [DataRow(72, 50)]
    [DataRow(98, 70)]
    [DataRow(120, 70)]
    public void TestFineMoreThan20kmhTooFastInsideSchoolzone(int actualSpeed, int speedLimit)
    {
        //1. Arrange: prepare everything for testing
        //int speedLimit = 30;  //This is now also a parameter
        int expectedFine = 250; // fine of 250€ is expected for this test
        bool inSchoolZone = true;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(25, 30, 0)]
    [DataRow(32, 30, 100)]
    [DataRow(41, 30, 150)]
    [DataRow(55, 30, 250)]
    [DataRow(25, 50, 0)]
    [DataRow(72, 70, 100)]
    [DataRow(88, 70, 150)]
    [DataRow(120, 70, 250)]
    public void TestFineWithDifferentSpeedsLimitsAndFinesInSchoolZone(int actualSpeed, int speedLimit, int expectedFine)
    {
        //1. Arrange: prepare everything for testing
        //int expectedFine = 200; //This is now also a parameter
        bool inSchoolZone = true;

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

    [DataTestMethod]
    [DataRow(25, 30, 0, false)]
    [DataRow(32, 30, 50, false)]
    [DataRow(41, 30, 150, true)]
    [DataRow(55, 30, 250, true)]
    [DataRow(25, 50, 0, true)]
    [DataRow(72, 70, 50, false)]
    [DataRow(88, 70, 100, false)]
    [DataRow(120, 70, 250, true)] //is this possible in reality ?
    public void TestFineWithDifferentSpeedsLimitsFinesAndSchoolZones(int actualSpeed, int speedLimit, int expectedFine, bool inSchoolZone)
    {
        //1. Arrange: prepare everything for testing
        //bool inSchoolZone = true; //This is now also a parameter

        //2. Act: run the test
        int actualFine = Datastructures_ClassLibrary.UnitTesting.FineCalculation.CalculateFine(actualSpeed, speedLimit, inSchoolZone);

        //3. Assert: check the result of the test
        Assert.AreEqual(expectedFine, actualFine);
    }

}
