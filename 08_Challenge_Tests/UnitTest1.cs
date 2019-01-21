using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        CustomerRepository _repo = new CustomerRepository();

        [TestMethod]
        public void RiskModifiers_ShouldHoldCorrectValue()
        {
            Customer customer = new Customer(1, 1, 1, 1);

            decimal actual = _repo.SpeedingMod(customer);
            decimal expected = 1.05m;

            decimal actualTwo = _repo.SwervingMod(customer);
            decimal expectedTwo = 1.05m;

            decimal actualThree = _repo.RollingStopMod(customer);
            decimal expectedThree = 1.05m;

            decimal actualFour = _repo.TailgatingMod(customer);
            decimal expectedFour = 1.05m;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);

        }

        [TestMethod]
        public void MyTestMethod()
        {
            Customer customer = new Customer(1, 1, 1, 1);

            decimal speedMod = _repo.SpeedingMod(customer);
            decimal swerveMod = _repo.SwervingMod(customer);
            decimal rollingStopMod = _repo.RollingStopMod(customer);
            decimal tailgaitingMod = _repo.TailgatingMod(customer);

            decimal unrounded =_repo.InsurancePremium(speedMod, swerveMod, tailgaitingMod, rollingStopMod);
            decimal actual = Decimal.Round(unrounded, 2);
            decimal expected = 243.10m;

            Assert.AreEqual(actual, expected);
        }
    }
}
