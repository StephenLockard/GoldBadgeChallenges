using System;
using _03_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Outing_Constructor_ShouldHoldCorrectValues()
        {
            Outing outing = new Outing(OutingType.Golf, 12, Convert.ToDateTime("12/12/1212"), 100, 12000);

            OutingType actual = outing.Type;
            OutingType expected = (OutingType)1;

            int actualOne = outing.Attendees;
            int expectedOne = 12;

            DateTime actualTwo = outing.Date;
            DateTime expectedTwo = Convert.ToDateTime("12/12/1212");

            decimal actualThree = outing.CostPerPerson;
            decimal expectedThree = 100;

            decimal actualFour = outing.TotalCost;
            decimal expectedFour = 12000 ;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
        }
    }
}
