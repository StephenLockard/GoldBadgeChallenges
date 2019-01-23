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
    public enum OutingType { Golf=1, Bowling, ThemePark, Concert}
    public class Outing
    {
        public OutingType Type { get; set; }
        public int Attendees { get; set; }
        public DateTime Date { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
        
        public Outing(OutingType type, int attendees, DateTime date, decimal costPerPerson, decimal totalCost)
        {
            Type = type;
            Attendees = attendees;
            Date = date;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;
        }
        public Outing()
        {

        }
    }
}
