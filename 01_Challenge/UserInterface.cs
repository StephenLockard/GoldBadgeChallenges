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
    public class UserInterface
    {
        Menu menuItem = new Menu();
        MenuRepository _repo = new MenuRepository();

        public void Run()
        {
            // this value creates a loop while true
            bool userContinue = true;
            
            // do all of this code while userContinue = true
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the menu editor! Please select an action: \n1) Add new menu item \n2) Delete menu item \n3) View menu\n  ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddMenuItem();
                        break;
                    case 2:
                        DeletionMethod();
                        Console.ReadKey();
                        break;
                    case 3:
                        PrintAllMenuItems();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            while (userContinue == true);
        }

        private void DeletionMethod()
        {
            Console.Clear();
            PrintAllMenuItems();
            Console.WriteLine("Which item would you like to remove?");
            int removalItem = int.Parse(Console.ReadLine());
            _repo.RemoveSpecificItem(removalItem);
        }

        public void AddMenuItem()
        {
            Menu menuItem = new Menu();
            Console.WriteLine("Enter the attriubutes of your new menu item: \nMenu Number?\n");
            menuItem.MealNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Name?");
            menuItem.MealName = Console.ReadLine();
            Console.WriteLine("Description?");
            menuItem.MealDescription = Console.ReadLine();
            Console.WriteLine("Ingredients?");
            menuItem.MealIngredients = Console.ReadLine();
            Console.WriteLine("Price?");
            menuItem.MealPrice = decimal.Parse(Console.ReadLine());
            _repo.AppendToList(menuItem);
            Console.WriteLine("The menu has been updated! Press any key to continue.");
            Console.ReadKey();
        }
        
        public void PrintAllMenuItems()
        {
            List<Menu> list = _repo.GetMenuList();
            foreach (Menu menuItem in list)
            {
                Console.WriteLine($"{menuItem.MealNumber}/) {menuItem.MealName} -- {menuItem.MealDescription} -- Ingredients: {menuItem.MealIngredients} -- ${menuItem.MealPrice} \n");
            }
        }
    }
}
