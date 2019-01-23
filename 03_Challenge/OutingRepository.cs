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
    public class OutingRepository
    {
        List<Outing> _golfList = new List<Outing>();
        List<Outing> bowlingList = new List<Outing>();
        List<Outing> themeParkList = new List<Outing>();
        List<Outing> concertList = new List<Outing>();

        public void AddToGolfList(Outing golf)
        {
            _golfList.Add(golf);
        }
        public void AddToBowlingList(Outing bowling)
        {
            bowlingList.Add(bowling);
        }
        public void AddToThemeParkList(Outing themePark)
        {
            themeParkList.Add(themePark);
        }
        public void AddToConcertList(Outing concert)
        {
            concertList.Add(concert);
        }

        public List<Outing> GetGolfList()
        {
            return _golfList;
        }
        public List<Outing> GetBowlingList()
        {
            return bowlingList;
        }
        public List<Outing> GetThemeParkList()
        {
            return themeParkList;
        }
        public List<Outing> GetConcertList()
        {
            return concertList;
        }


        public decimal CostOfGolfEvents()
        {
            decimal cost = 0;
            foreach (Outing outing in _golfList)
            {
                cost += outing.TotalCost;
            }
                return cost;
        }

        public decimal CostOfBowlingEvents()
        {
            decimal cost = 0;
            foreach (Outing outing in bowlingList)
            {
                cost += outing.TotalCost;
            }
            return cost;
        }

        public decimal CostOfThemeParkEvents()
        {
            decimal cost = 0;
            foreach (Outing outing in themeParkList)
            {
                cost += outing.TotalCost;
            }
            return cost;
        }

        public decimal CostOfConcertEvents()
        {
            decimal cost = 0;
            foreach (Outing outing in concertList)
            {
                cost += outing.TotalCost;
            }
            return cost;
        }
    }
}
