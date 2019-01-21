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
    class ProgramUI
    {
        CustomerRepository _repo = new CustomerRepository();
        Customer customer = new Customer();

        public void Run()
        {
            bool userContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to our risk Assessor! Please select an action: \n1) Add new customer \n2) Exit\n  ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddCustomer();
                        break;
                    default:
                        break;
                }
            }
            while (userContinue == true);
        }

        public void AddCustomer()
        {
            Customer customer = new Customer();
            Console.WriteLine("How many speeding violations have they had this year?");
            customer.SpeedingInfractionsPerYear = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times per month do they swerve outside the lines?");
            customer.SwervesPerMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How many rolling stops do they perform per month?");
            customer.RollingStopsPerMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("How often do they tailgate per month?");
            customer.TailgatesPerMonth = int.Parse(Console.ReadLine());

            decimal speedMod = _repo.SpeedingMod(customer);
            decimal swerveMod = _repo.SwervingMod(customer);
            decimal rollingStopMod = _repo.RollingStopMod(customer);
            decimal tailgaitingMod = _repo.TailgatingMod(customer);

            decimal totalCost = _repo.InsurancePremium(speedMod, swerveMod, tailgaitingMod, rollingStopMod);
            Console.WriteLine("Your insurance premium will be $" + Decimal.Round(totalCost, 2) + " per month.");
            Console.ReadKey();
        }

    }
}
