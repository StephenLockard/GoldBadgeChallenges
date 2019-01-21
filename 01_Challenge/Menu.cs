using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The Komodo Cafe is getting a new menu. 
The cafe manager at Komodo wants to be able to create a menu item, delete a menu item,
and list all items on the cafe's menu. She needs a console app. 
Each of their menu items will contain the following:
a meal number so employees can say "I'll have the #5", 
a meal name, 
a description, 
a list of ingredients in the meal, 
and a price.  
Your task is to do the following:
1. Create a Menu class with properties, constructors, and fields.
2. Create a MenuRepository class that has methods needed.
3. Create a Test Class for your repository methods. (You don't need to test
your constructors or objects. Just the methods.)
4. Create a Program file that allows the restaurant manager to add, delete, 
and see all items in the menu list.
Notes:
We don't need to update the items right now.*/

namespace _01_Challenge
{
    public class Menu
    {
        public int MealNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string MealIngredients { get; set; }
        public decimal MealPrice { get; set; }

        public Menu(int mealNumber, string mealName, string mealDescription, string mealIngredients, decimal mealPrice)
        {
            MealNumber = mealNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            MealIngredients = mealIngredients;
            MealPrice = mealPrice;

        }

        public Menu()
        {

        }
    }
}
