using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Challenge
{
/* The Program will allow a security staff member to do the following:
create a new badge
update doors on an existing badge.
delete all doors from an existing badge.
show a list with all badge numbers and door access, like this:
Here are some views:
Menu
    Hello Security Admin, What would you like to do?
    1. Add a badge
    2. Edit a badge.
    3. List all Badges
#1 Add a badge
    What is the number on the badge:  12345
    List a door that it needs access to: A5
    Any other doors(y/n)? y
    List a door that it needs access to: A7
    Any other doors(y/n)? n
    (Return to main menu.)
#2 Update a badge
    What is the badge number to update? 12345
    12345 has access to doors A5 & A7.
    What would you like to do?
        1. Remove a door
        2. Add a door
    > 1
    
    Which door would you like to remove? A5
    Door removed.
    12345 has access to door A7.
#3 List all badges view
    Key
    Badge #          Door Access       
    12345            A7
    22345            A1, A4, B1, B2
    32345            A4, A5
Out of scope:
You do not need to consider tying an individual badge to a particular user.Just the Badge # will do.
Be sure to Unit Test your Repository methods.*/

    public class ProgramUI
    {

        BadgeRepository _repo = new BadgeRepository();
        Dictionary<int, List<string>> _badges = new Dictionary<int, List<string>>();

        public void Run()
        {
            

            bool userContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the security badge tool. Please select an action: \n1) Add a badge \n2) Edit a badge \n3) Delete a badge \n4) See all badges\n");
                int userSelection = int.Parse(Console.ReadLine());

                start:
                switch (userSelection)
                {
                    case 1:
                        AddBadge();
                        Console.ReadKey();
                        break;
                    case 2:
                        EditBadge();
                        break;
                    case 3:
                        DeleteBadge();
                        break;
                    case 4:
                        SeeBadges();
                        break;
                    default:
                        Console.WriteLine("Invalid selection!");
                        goto start;
                }
            } while (userContinue);
        }


        public void AddBadge()
        {
            var badge = new Badge();
            var listOfDoors = new List<string>();
            Console.WriteLine("Badge ID?");
            badge.BadgeID = int.Parse(Console.ReadLine());

            bool addMoreDoors = true;
            while(addMoreDoors)
            {
                Console.WriteLine("Add a door name for access");
                listOfDoors.Add(Console.ReadLine());

                Console.WriteLine("Add more doors? [Yes, No]");
                string userDoorsResponse = Console.ReadLine().ToLower();
                if (userDoorsResponse == "no")
                {
                    badge.AccessibleDoors = listOfDoors;
                    _repo.AddBadgeToDictionary(badge);
                    addMoreDoors = false;
                }
            } 
        }

        private void EditBadge()
        {
            Console.Clear();
            Dictionary<int, List<string>> _badges = _repo.GetDictionary();
            foreach (KeyValuePair<int, List<string>> badge in _badges)
            {
                Console.WriteLine("Badge #" + badge.Key + " has access to these doors: ");
                foreach (string item in badge.Value)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            };
            Console.WriteLine("Which badge would you like to edit?");
            int userUpdateSelection = int.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, List<string>> badge in _badges)
            {
                if (badge.Key == userUpdateSelection)
                {
                    var updatedBadge = new Badge();
                    var updatedListOfDoors = new List<string>();

                    Console.WriteLine("Badge ID?");
                    updatedBadge.BadgeID = int.Parse(Console.ReadLine());
                    bool addMoreDoors = true;
                    while (addMoreDoors)
                    {
                        Console.WriteLine("Add a door name for access");
                        updatedListOfDoors.Add(Console.ReadLine());

                        Console.WriteLine("Add more doors? [Yes, No]");
                        string userDoorsResponse = Console.ReadLine().ToLower();
                        if (userDoorsResponse == "no")
                        {
                            updatedBadge.AccessibleDoors = updatedListOfDoors;
                            _repo.AddBadgeToDictionary(updatedadge);
                            addMoreDoors = false;
                        }
                    }

                    break;
                }
            }
        }

        private void DeleteBadge()
        {
            throw new NotImplementedException();
        }

        private void SeeBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> _badges = _repo.GetDictionary();
            foreach (KeyValuePair<int, List<string>> badge in _badges)
            {
                Console.WriteLine("Badge #" + badge.Key + " has access to these doors: ");
                foreach (string item in badge.Value)
                {
                    Console.WriteLine(item);
                }
                Console.ReadKey();
            };
        }
    }
}
