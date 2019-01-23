using System;
using _06_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _06_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Vehicle_Constructor_ShouldHoldCorrectValues()
        {
            Vehicle vehicle = new Vehicle(123, VehicleType.Gas, "Chevy", 4, false);

            int actual = vehicle.VehicleID;
            int expected = 123;

            VehicleType actualOne = vehicle.Type;
            VehicleType expectedOne = VehicleType.Gas;

            string actualTwo = vehicle.Make;
            string expectedTwo = "Chevy";

            int actualThree = vehicle.NumberOfDoors;
            int expectedThree = 4;

            bool actualFour = vehicle.IsRed;
            bool expectedFour = false;

            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);

        }

        [TestMethod]
        public void List_Methods_Should_ProperlyPerform_CRUD_Fuctions()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle vehicleTwo = new Vehicle();
            Vehicle vehicleThree = new Vehicle();
            Vehicle vehicleFour = new Vehicle();
            Vehicle vehicleFive = new Vehicle();
            VehicleRepository _repo = new VehicleRepository();

            _repo.AddToGasList(vehicle);
            _repo.AddToHybridList(vehicleTwo);
            _repo.AddToElectricList(vehicleThree);
            _repo.AddToGasList(vehicleFour);
            _repo.AddToHybridList(vehicleFive);

            int actual = _repo.GetGasList().Count;
            int expected = 2;

            int actualOne = _repo.GetHybridList().Count;
            int expectedOne = 2;

            int actualTwo = _repo.GetElectricList().Count;
            int expectedTwo = 1;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualOne, expectedOne);
            Assert.AreEqual(actualTwo, expectedTwo);


            _repo.RemoveFromGasList(vehicle);
            _repo.RemoveFromHybridList(vehicleTwo);
            _repo.RemoveFromElectricList(vehicleThree);

            int actualThree = _repo.GetGasList().Count;
            int expectedThree = 1;

            int actualFour = _repo.GetHybridList().Count;
            int expectedFour = 1;

            int actualFive = _repo.GetElectricList().Count;
            int expectedFive = 0;

            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
            Assert.AreEqual(actualFive, expectedFive);
        }
    }
}
