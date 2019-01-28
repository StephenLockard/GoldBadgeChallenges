using System;
using System.Collections.Generic;
using _04_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Dictionary<int, List<string>> _badges = new Dictionary<int, List<string>>();
        BadgeRepository _repo = new BadgeRepository();

        [TestMethod]
        public void Badge_Constructor_ShouldHoldCorrectValues()
        {
            Badge badge = new Badge(123, new List<string> { "a5", "a6" });

            int actual = badge.BadgeID;
            int expected = 123;
            
            Assert.IsTrue(badge.AccessibleDoors.Contains("a5") && badge.AccessibleDoors.Contains("a6"));
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void List_Functions_Act_Appropriately()
        {
            Badge badgeOne = new Badge(123, new List<string> { "a5", "a6" });
            Badge badgeTwo = new Badge(456, new List<string> { "a5", "a6", "a7" });
            Badge badgeThree = new Badge(789, new List<string> { "a5", "a6", "j9" });

            _repo.AddBadgeToDictionary(badgeOne);
            _repo.AddBadgeToDictionary(badgeTwo);
            _repo.AddBadgeToDictionary(badgeThree);

            int actual = _repo.GetDictionary().Count;
            int expected = 3;

            Assert.AreEqual(actual, expected);

            _repo.RemoveBadgeFromDictionary(badgeOne);

            int actualOne = _repo.GetDictionary().Count;
            int expectedOne = 2;

            Assert.AreEqual(actualOne, expectedOne);
        }

        [TestMethod]
        public void Specific_Removal_FunctionsAppropriately()
        {
            Badge badgeOne = new Badge(123, new List<string> { "a5", "a6" });
            Badge badgeTwo = new Badge(456, new List<string> { "a5", "a6", "a7" });
            Badge badgeThree = new Badge(789, new List<string> { "a5", "a6", "j9" });

            _repo.AddBadgeToDictionary(badgeOne);
            _repo.AddBadgeToDictionary(badgeTwo);
            _repo.AddBadgeToDictionary(badgeThree);

            int actual = _repo.GetDictionary().Count;
            int expected = 3;

            Assert.AreEqual(actual, expected);

            _repo.RemoveSpecificItem(123);

            _repo.RemoveBadgeFromDictionary(badgeOne);

            int actualOne = _repo.GetDictionary().Count;
            int expectedOne = 2;

            Assert.AreEqual(actualOne, expectedOne);

        }

    }
}
