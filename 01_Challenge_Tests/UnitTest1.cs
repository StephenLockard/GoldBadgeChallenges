using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Menu_Constructor_ShouldHoldCorrectValues()
        {
            Menu menu = new Menu(1, "Double Cheeseburger", "Goes well with cheese!", "Two all beef patties", 5.00m);
            int actual = menu.MealNumber;
            int expected = 1;

            string actualTwo = menu.MealName;
            string expectedTwo = "Double Cheeseburger";

            string actualThree = menu.MealDescription;
            string expectedThree = "Goes well with cheese!";

            string actualFour = menu.MealIngredients;
            string expectedFour = "Two all beef patties";

            decimal actualFive = menu.MealPrice;
            decimal expectedFive = 5.00m;

            Assert.AreEqual(actual, expected);
            Assert.AreEqual(actualTwo, expectedTwo);
            Assert.AreEqual(actualThree, expectedThree);
            Assert.AreEqual(actualFour, expectedFour);
            Assert.AreEqual(actualFive, expectedFive);
        }

        [TestMethod]
        public void List_Functions_ShoulProperly_Add_Remove_Retrieve_TheList()
        {
            Menu menu = new Menu();
            Menu menuTwo = new Menu();
            Menu menuThree = new Menu();
            MenuRepository _repo = new MenuRepository();

            _repo.AppendToList(menu);
            _repo.AppendToList(menuTwo);
            _repo.AppendToList(menuThree);

            int actual = _repo.GetMenuList().Count;
            int expected = 3;

            Assert.AreEqual(actual, expected);

            _repo.RemoveFromList(menu);

            int actualTwo = _repo.GetMenuList().Count;
            int expectedTwo = 2;

            Assert.AreEqual(actualTwo, expectedTwo);

        }

        [TestMethod]
        public void RemoveSpecificItem_Function_ShouldProperly_RemoveSpecificItem()
        {
            Menu menu = new Menu(1, "Burger", "A very tasty hamburger", "Ground beef", 5.00m);
            Menu menuTwo = new Menu(2, "Pizza", "Very cheese, much wow", "Cheese, we told you already!", 6.00m);
            Menu menuThree = new Menu(3, "Salad", "It's green!", "lettuce and stuff", 11.00m);

            MenuRepository _repo = new MenuRepository();

            _repo.AppendToList(menu);
            _repo.AppendToList(menuTwo);
            _repo.AppendToList(menuThree);

            _repo.RemoveFromList(menu);

            Assert.IsFalse(_repo.GetMenuList().Contains(menu));
        }
    }
}
