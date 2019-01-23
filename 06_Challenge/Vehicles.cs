using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Komodo Green Plan
Komodo Insurance is trying to add a Green Plan for their
customers that provides incentives for owning an Electric or
Hybrid car.
Before they are able to configure any pricing or deals,
they want to collect general information on Electric, Hybrid, and Gas cars
so that they can do various comparisons. 
The purpose of the app on this sprint will be to
collect, read, delete, and update data on gas, electric, and hybrid cars.
To be more specific, they want to create an app that allows a
Komodo Agent to do full CRUD + List on those three types of cars.
For example, a KI employee can go on and create
a Tesla, add it to an Electric Car list, update it, see the details
for the car, and delete it from the Electric Car list. 
They could also see a full list of Electric cars that have been added. 
They can do the same thing for Gas Cars and Hybrid Cars with the
eventual hope that the collected data will help with various comparisons. 
Be sure to Unit Test your code. */

namespace _06_Challenge
{
    public enum VehicleType { Gas=1, Hybrid, Electric}
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public VehicleType Type { get; set; }
        public string Make { get; set; }
        public int NumberOfDoors { get; set; }
        public bool IsRed { get; set; }


        public Vehicle(int vehicleID, VehicleType type, string make, int numberOfDoors, bool isRed)
        {
            VehicleID = vehicleID;
            Type = type;
            Make = make;
            NumberOfDoors = numberOfDoors;
            IsRed = isRed;
        }

        public Vehicle()
        {

        }
    }
}
