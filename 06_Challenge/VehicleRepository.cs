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
    public class VehicleRepository
    {
        
        List<Vehicle> gasList = new List<Vehicle>();
        List<Vehicle> hybridList = new List<Vehicle>();
        List<Vehicle> electricList = new List<Vehicle>();
        
        public void AddToGasList(Vehicle gasVehicle)
        {
            gasList.Add(gasVehicle);
        }
        public void AddToHybridList(Vehicle hybridVehicle)
        {
            hybridList.Add(hybridVehicle);
        }
        public void AddToElectricList(Vehicle electricVehicle)
        {
            electricList.Add(electricVehicle);
        }
      

      public void RemoveFromGasList(Vehicle gasVehicle)
         {
             gasList.Remove(gasVehicle);
         }
         public void RemoveFromHybridList(Vehicle hybridVehicle)
         {
             hybridList.Remove(hybridVehicle);
         }
         public void RemoveFromElectricList(Vehicle electricVehicle)
         {
             electricList.Remove(electricVehicle);
         }

        public void RemoveSpecificItemFromGasList(int vehicleMatch)
        {
            foreach (Vehicle vehicle in gasList)
            {
                if (vehicle.VehicleID == vehicleMatch)
                {
                    RemoveFromGasList(vehicle);
                }
            }
        }
        public void RemoveSpecificItemFromHybridList(int vehicleMatch)
        {
            foreach (Vehicle vehicle in hybridList)
            {
                if (vehicle.VehicleID == vehicleMatch)
                {
                    RemoveFromHybridList(vehicle);
                }
            }
        }
        public void RemoveSpecificItemFromElectricList(int vehicleMatch)
        {
            foreach (Vehicle vehicle in hybridList)
            {
                if (vehicle.VehicleID == vehicleMatch)
                {
                    RemoveFromElectricList(vehicle);
                }
            }
        }

        public List<Vehicle> GetGasList()
        {
            return gasList;
        }
        public List<Vehicle> GetHybridList()
        {
            return hybridList;
        }
        public List<Vehicle> GetElectricList()
        {
            return electricList;
        }
    }
}
