using System;
using _02_challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Menu_Constructor_ShouldHoldCorrectValues()
        {
            Claim claim = new Claim(1, "HomeOwners", "Home Fire", 15000, Convert.ToDateTime("11/11/18"), Convert.ToDateTime("11/15/18"));
            int actual = claim.ClaimID;
            int expected = 1;

            string actualTwo = claim.ClaimType;
            string expectedTwo = "HomeOwners";

            decimal actualThree = claim.ClaimAmount;
            decimal expectedThree = 15000;

            DateTime actualFour = claim.AccidentDate;
            DateTime expectedFour = Convert.ToDateTime("11/11/18");

            DateTime actualFive = claim.ClaimDate;
            DateTime expectedFive = Convert.ToDateTime("11/15/18");

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
            Assert.AreEqual(actualFive, expectedFive);
        }

        [TestMethod]
        public void List_Functions_ShoulProperly_Add_Remove_Retrieve_TheList()
        {
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();
            ClaimRepository _repo = new ClaimRepository();

            _repo.AppendToList(claim);
            _repo.AppendToList(claimTwo);
            _repo.AppendToList(claimThree);

            int actual = _repo.GetList().Count;
            int expected = 3;

            Assert.AreEqual(actual, expected);

            _repo.RemoveFromList(claim);

            int actualTwo = _repo.GetList().Count;
            int expectedTwo = 2;

            Assert.AreEqual(actualTwo, expectedTwo);

        }

        [TestMethod]
        public void RemoveSpecificItem_Function_ShouldProperly_RemoveSpecificItem()
        {
            Claim claim = new Claim(1, "homeowners", "fire", 15000, Convert.ToDateTime("11/11/13"), Convert.ToDateTime("11/15/13"));
            Claim claimTwo = new Claim(1, "car", "collision", 10000, Convert.ToDateTime("11 / 12 / 13"), Convert.ToDateTime("11 / 15 / 13"));
            Claim claimThree = new Claim(1, "motorcycle", "theft", 5000, Convert.ToDateTime("11 / 12 / 13"), Convert.ToDateTime("11 / 15 / 13"));

            ClaimRepository _repo = new ClaimRepository();

            _repo.AppendToList(claim);
            _repo.AppendToList(claimTwo);
            _repo.AppendToList(claimThree);

            _repo.RemoveFromList(claim);

            Assert.IsFalse(_repo.GetList().Contains(claim));
        }
    }
}
