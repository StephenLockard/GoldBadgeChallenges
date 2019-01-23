using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Komodo Outings
Komodo accountants need a list of all outings, the cost of all outings combined, and the 
cost of all types of outings combined. 
Here are the parts of an outing:
    Event Type:
    Golf, Bowling, Amusement Park, Concert
    Number of people that attended,
    Date,
    Total cost per person for the event,
    Total cost for the event
Here's what they'd like:
1. Display a list of all outings.
2. Add individual outings to a list(don't need to worry about delete yet)
3. Calculations: 
    They'd like to see a display for the combined cost for all outings.
    They'd like to see a display of outing costs by type. */

namespace _03_Challenge
{
    public class ProgramUI
    {
        OutingRepository _repo = new OutingRepository();

        public void Run()
        {
            bool usercontinue = true;
            do
            {
                Console.WriteLine("Hello and welcome to the menu editor! Please select an action: \n1) Add new event\n2) See all events\n3) See Costs ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddEvent();
                        Console.ReadKey();
                        break;
                    case 2:
                        DisplayEvents();
                        Console.ReadKey();
                        break;
                    case 3:
                        SeeCosts();
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
            while (usercontinue);
        }

        private void SeeCosts()
        {
            Console.Clear();

            List<Outing> masterList = new List<Outing>();
            List<Outing> golfList = _repo.GetGolfList();
            List<Outing> bowlingList = _repo.GetBowlingList();
            List<Outing> themeParkList = _repo.GetThemeParkList();
            List<Outing> concertList = _repo.GetConcertList();

            Console.WriteLine("Which events would you like costs of? \n[1) All Events 2) Golf 3) Bowling 4) Theme Parks 5) Concerts");
            int userDisplaySelection = int.Parse(Console.ReadLine());

            switch (userDisplaySelection)
            {
                case 1:
                    decimal golfCost = _repo.CostOfGolfEvents();
                    decimal bowlingCost = _repo.CostOfBowlingEvents();
                    decimal themeParkCost = _repo.CostOfThemeParkEvents();
                    decimal concertCost = _repo.CostOfConcertEvents();

                    decimal totalCost = golfCost + bowlingCost + themeParkCost + concertCost;
                    Console.WriteLine($"Total cost is ${totalCost}");
                    Console.ReadKey();
                    break;
                case 2:
                    decimal totalGolfCost = _repo.CostOfGolfEvents();
                    Console.WriteLine($"{totalGolfCost}");
                    break;
                case 3:
                    decimal totalBowlingCost = _repo.CostOfBowlingEvents();
                    Console.WriteLine($"{totalBowlingCost}");
                    break;
                case 4:
                    decimal totalThemeParkCost = _repo.CostOfThemeParkEvents();
                    Console.WriteLine($"{totalThemeParkCost}");
                    break;
                case 5:
                    decimal totalConcertCost = _repo.CostOfConcertEvents();
                    Console.WriteLine($"{totalConcertCost}");
                    break;
                default:
                    break;
            }
        }

        private void DisplayEvents()
        {
            Console.Clear();

            List<Outing> masterList = new List<Outing>();
            List<Outing> golfList = _repo.GetGolfList();
            List<Outing> bowlingList = _repo.GetBowlingList();
            List<Outing> themeParkList = _repo.GetThemeParkList();
            List<Outing> concertList = _repo.GetConcertList();

            Console.WriteLine("Which events would you like to see? \n[1) All Events 2) Golf 3) Bowling 4) Theme Parks 5) Concerts");
            int userDisplaySelection = int.Parse(Console.ReadLine());
            switch (userDisplaySelection)
            {
                case 1:
                    masterList = masterList.Concat(golfList).Concat(bowlingList).Concat(themeParkList).Concat(concertList).ToList();
                    Console.WriteLine("Outing Type \t # Attendees \t\t Date \t Cost Per Person \t Total Cost");
                    foreach (Outing outing in masterList)
                    {
                        Console.WriteLine($"{outing.Type}, {outing.Attendees}, {outing.Date}, {outing.CostPerPerson}, {outing.TotalCost}");
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    Console.WriteLine("Outing Type \t # Attendees \t Date \t Cost Per Person \t Total Cost");
                    foreach (Outing outing in golfList)
                    {
                        Console.WriteLine($"{outing.Type}, {outing.Attendees}, {outing.Date}, {outing.CostPerPerson}, {outing.TotalCost}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Outing Type \t # Attendees \t\t Date \t Cost Per Person \t Total Cost");
                    foreach (Outing outing in bowlingList)
                    {
                        Console.WriteLine($"{outing.Type}, {outing.Attendees}, {outing.Date}, {outing.CostPerPerson}, {outing.TotalCost}");
                    }
                    break;
                case 4:
                    Console.WriteLine("Outing Type \t # Attendees \t\t Date \t Cost Per Person \t Total Cost");
                    foreach (Outing outing in themeParkList)
                    {
                        Console.WriteLine($"{outing.Type}, {outing.Attendees}, {outing.Date}, {outing.CostPerPerson}, {outing.TotalCost}");
                    }
                    break;
                case 5:
                    Console.WriteLine("Outing Type \t # Attendees \t\t Date \t Cost Per Person \t Total Cost");
                    foreach (Outing outing in concertList)
                    {
                        Console.WriteLine($"{outing.Type}, {outing.Attendees}, {outing.Date}, {outing.CostPerPerson}, {outing.TotalCost}");
                    }
                    break;
                default:
                    break;
            }
        }

        private void AddEvent()
        {
            DateTime date;
            Outing outing = new Outing();
           

            Console.WriteLine("What is the outing type? \n[1) Golf, 2) Bowling, 3) Theme Park, 4) Concert");
            int userEnumSelection = int.Parse(Console.ReadLine());
            OutingType userOutingType = (OutingType)userEnumSelection;
            outing.Type = userOutingType;
            Console.WriteLine("How many Attendees?");
            outing.Attendees = int.Parse(Console.ReadLine());
            Console.WriteLine("Date in mm/dd/yyyy format?");
            if (DateTime.TryParse(Console.ReadLine(), out date))
            {
                outing.Date = date;
            }
            else
            {
                Console.WriteLine("Format Error");
            }
            Console.WriteLine("Cost per person?");
            outing.CostPerPerson = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Total cost of event?");
            outing.TotalCost = decimal.Parse(Console.ReadLine());
            switch (userEnumSelection)
            {
                case 1:
                    _repo.AddToGolfList(outing);
                    break;
                case 2:
                    _repo.AddToBowlingList(outing);
                    break;
                case 3:
                    _repo.AddToThemeParkList(outing);
                    break;
                case 4:
                    _repo.AddToConcertList(outing);
                    break;
                default:
                    break;
            }
        }
    }
}
