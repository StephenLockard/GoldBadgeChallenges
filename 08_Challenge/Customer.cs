using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Smart Insurance
Komodo wants to work with smart cars that collect driver data to calculate the costs of car insurance. 
The car tracks all the data for a driver: how often they speed or follow the speed limit,
how often they swerve outside of their lane, how often they roll through a stop sign, and 
how often they follow too closely. 
Write a program that shows premium costs based on a driver's driving habits. Obviously, if a driver has
poor driving skills, their premium will be higher.
Note: This is very open ended and allows you to be creative. A base premium cost can be
an estimated number and a premium is the monthly amount that a driver would pay.*/

namespace _08_Challenge
{
    public class Customer
    {
        public int SpeedingInfractionsPerYear { get; set; }
        public int SwervesPerMonth { get; set; }
        public int RollingStopsPerMonth { get; set; }
        public int TailgatesPerMonth { get; set; }

        public Customer(int speedingInfractionsPerYear, int swervesPerMonth, int rollingStopsPerMonth, int tailgatesPerMonth)
        {
            SpeedingInfractionsPerYear = speedingInfractionsPerYear;
            SwervesPerMonth = swervesPerMonth;
            RollingStopsPerMonth = rollingStopsPerMonth;
            TailgatesPerMonth = tailgatesPerMonth;
        }
        public Customer()
        {

        }
    }
}
