using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Komodo Claims Department
Komodo has a bug in its claims software and needs some new code.
A Claim has the following properties:
ClaimID, ClaimType, Description, ClaimAmount, DateOfIncident, DateOfClaim, IsValid
Komodo allows an insurance claim to be made up to 30 days after an incident
took place.If the claim is not in the proper time limit, it is not valid. 
A ClaimType could be the following:
    Car, Home, Theft
The app will need methods in to do the following:
Show a claims agent a menu:
Choose a menu item:
1. See all claims
2. Take care of next claim
3. Enter a new claim
For #1, a claims agent could see all items in the queue listed out like this:
ClaimID Type    Description Amount      DateOfAccident DateOfClaim      IsValid
1          Car Car accident on 465.     $400.00     4/25/18         4/27/18          True 
2          House House fire in kitchen.   $4000.00    4/26/18         4/28/18          True
3          Theft Stolen pancakes.         $4.00       4/27/18         6/01/18          False
For #2, when a claims agent needs to deal with an item they see the next item in the queue.
    Here are the details for the next claim to be handled:
    ClaimID: 1
    Type: Car
    Description: Car Accident on 464.
    Amount: $400.00
    DateOfAccident: 4/25/18
    DateOfClaim: 4/27/18
    IsValid: True

    Do you want to deal with this claim now(y/n)?  y

When the agent presses 'y', the claim will be pulled off the top of the queue. If the agent presses 'n', it will go back to the main menu.
For #3, when a claims agent enters new data about a claim they will be prompted for questions about it:
    Enter the claim id: 4
    Enter the claim type: Car
    Enter a claim description: Wreck on I-70.
    Amount of Damage: $2000.00
    Date Of Accident: 4/27/18
    Date of Claim: 4/28/18
    This claim is valid.
Your goal is to do the following:
1. Create a Claim class with properties, constructors, and any necessary fields.
2. Create a ClaimRepository class that has proper methods.
3. Create a Test Class for your repository methods.
4. Create a Program file that allows a claims manager to manage items in a list of claims. */

namespace _02_challenge
{
    public class ProgramUI
    {
        Claim claim = new Claim();
        ClaimRepository _repo = new ClaimRepository();

        public void Run()
        {
            bool userContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the menu editor! Please select an action: \n1) Add new claim \n2) Delete claim \n3) See all claims\n  ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddClaimItem();
                        break;
                    case 2:
                        DeletionMethod();
                        Console.ReadKey();
                        break;
                    case 3:
                        PrintAllClaimItems();
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
            PrintAllClaimItems();
            Console.WriteLine("Which item would you like to remove?");
            int removalItem = int.Parse(Console.ReadLine());
            _repo.RemoveSpecificItem(removalItem);
        }

        public void AddClaimItem()
        {
            DateTime accidentDateTime;
            DateTime claimDateTime;
            Claim claim = new Claim();

            Console.WriteLine("Enter claim attributes \nClaim ID?\n");
            claim.ClaimID = int.Parse(Console.ReadLine());
            Console.WriteLine("Claim Type?\n");
            claim.ClaimType = Console.ReadLine();
            Console.WriteLine("Description?\n");
            claim.Description = Console.ReadLine();
            Console.WriteLine("Claim Amount?\n");
            claim.ClaimAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Accident Date in mm/dd/yyyy format?");
            if (DateTime.TryParse(Console.ReadLine(), out accidentDateTime))
            {
                claim.AccidentDate = accidentDateTime;
            }
            else
            {
                Console.WriteLine("Format Error");
            }
            Console.WriteLine("Claim Date in mm/dd/yyyy format?");
            if (DateTime.TryParse(Console.ReadLine(), out claimDateTime))
            {
                claim.ClaimDate = claimDateTime;
            }
            else
            {
                Console.WriteLine("Format Error");
            }
            if ((claim.ClaimDate - claim.AccidentDate).Days >= 30)
            {
                claim.isValid = false;
            }
            else
            {
                claim.isValid = true;
            }
            _repo.AppendToList(claim);
            Console.WriteLine("The claims list has been updated! Press any key to continue.");
            Console.ReadKey();
        }

        public void PrintAllClaimItems()
        {
            Console.WriteLine("ClaimID   Type    Description   Amount      DateOfAccident       DateOfClaim   IsValid");
            List<Claim> claimList = _repo.GetList();
            foreach (Claim claim in claimList)
            {
                Console.WriteLine($"{claim.ClaimID}/) {claim.ClaimType} -- {claim.Description} -- {claim.ClaimAmount} -- {claim.AccidentDate} -- {claim.ClaimDate} {claim.isValid}\n");
            }
        }
    }
}
