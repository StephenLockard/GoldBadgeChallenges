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
    public class ProgramUI
    {
        Vehicle claim = new Vehicle();
        VehicleRepository _repo = new VehicleRepository();

        public void Run()
        {
            bool userContinue = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello and welcome to the vehicle editor! Please select an action: \n1) Add new vehicle \n2) Delete vehicle \n3) Update vehicle \n4) See All Vehicles \n5) Exit ");
                int userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        AddVehicle();
                        break;
                    case 2:
                        DeletionMethod();
                        break;
                    case 3:
                        UpdateMethod();
                        break;
                    case 4:
                        PrintList();
                        break;
                    default:
                        break;
                }
            }
            while (userContinue);
        }

        public void AddVehicle()
        {
            Vehicle vehicle = new Vehicle();
           

            Console.WriteLine("Enter vehicle attributes.\nVIN?\n");
            vehicle.VehicleID = int.Parse(Console.ReadLine());
            Console.WriteLine("Vehicle Type?\n1) Gas \n2) Hybrid \n3) Electric");
            int userEnumSelection = int.Parse(Console.ReadLine());
            VehicleType userVehicleType = (VehicleType)userEnumSelection;
            Console.WriteLine("Make?\n");
            vehicle.Make = Console.ReadLine();
            Console.WriteLine("Number of doors?\n");
            vehicle.NumberOfDoors = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the vehicle red? [True / False]\n");
            vehicle.IsRed = bool.Parse(Console.ReadLine());
            Console.ReadKey();

            switch (userEnumSelection)
            {
                case 1:
                    _repo.AddToGasList(vehicle);
                    break;
                case 2:
                    _repo.AddToHybridList(vehicle);
                    break;
                case 3:
                    _repo.AddToElectricList(vehicle);
                    break;
                default:
                    Console.WriteLine("Invalid Type");
                    break;
            }
        }

        private void UpdateMethod()
        {
            Console.Clear();
            Console.WriteLine("Which list would you like to update? \n1) Gas Vehicles \n2) Hybrid Vehicles \n3) Electric Vehicles \n");
            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    List<Vehicle> gasList = _repo.GetGasList();
                    foreach (Vehicle vehicle in gasList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich VIN# would you like to update?");
                    int gasVehicleVinMatch = int.Parse(Console.ReadLine());
                    foreach (Vehicle vehicle in gasList)
                    {
                        if (vehicle.VehicleID == gasVehicleVinMatch)
                        {
                            Console.WriteLine("Enter vehicle attributes.\nVIN?\n");
                            vehicle.VehicleID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle Type?\n1) Gas \n2) Hybrid \n3) Electric");
                            int userEnumSelection = int.Parse(Console.ReadLine());
                            VehicleType userVehicleType = (VehicleType)userEnumSelection;
                            Console.WriteLine("Make?\n");
                            vehicle.Make = Console.ReadLine();
                            Console.WriteLine("Number of doors?\n");
                            vehicle.NumberOfDoors = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is the vehicle red? [True / False]\n");
                            vehicle.IsRed = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle has been updated");
                            Console.ReadKey();
                        }
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    List<Vehicle> hybridList = _repo.GetGasList();
                    foreach (Vehicle vehicle in hybridList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich VIN# would you like to update?");
                    int hybridVehicleVinMatch = int.Parse(Console.ReadLine());
                    foreach (Vehicle vehicle in hybridList)
                    {
                        if (vehicle.VehicleID == hybridVehicleVinMatch)
                        {
                            Console.WriteLine("Enter vehicle attributes.\nVIN?\n");
                            vehicle.VehicleID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle Type?\n1) Gas \n2) Hybrid \n3) Electric");
                            int userEnumSelection = int.Parse(Console.ReadLine());
                            VehicleType userVehicleType = (VehicleType)userEnumSelection;
                            Console.WriteLine("Make?\n");
                            vehicle.Make = Console.ReadLine();
                            Console.WriteLine("Number of doors?\n");
                            vehicle.NumberOfDoors = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is the vehicle red? [True / False]\n");
                            vehicle.IsRed = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle has been updated");
                            Console.ReadKey();
                        }
                    }
                    break;
                case 3:
                    List<Vehicle> electricList = _repo.GetGasList();
                    foreach (Vehicle vehicle in electricList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich VIN# would you like to update?");
                    int electricVehicleVinMatch = int.Parse(Console.ReadLine());
                    foreach (Vehicle vehicle in electricList)
                    {
                        if (vehicle.VehicleID == electricVehicleVinMatch)
                        {
                            Console.WriteLine("Enter vehicle attributes.\nVIN?\n");
                            vehicle.VehicleID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle Type?\n1) Gas \n2) Hybrid \n3) Electric");
                            int userEnumSelection = int.Parse(Console.ReadLine());
                            VehicleType userVehicleType = (VehicleType)userEnumSelection;
                            Console.WriteLine("Make?\n");
                            vehicle.Make = Console.ReadLine();
                            Console.WriteLine("Number of doors?\n");
                            vehicle.NumberOfDoors = int.Parse(Console.ReadLine());
                            Console.WriteLine("Is the vehicle red? [True / False]\n");
                            vehicle.IsRed = bool.Parse(Console.ReadLine());
                            Console.WriteLine("Vehicle has been updated");
                            Console.ReadKey();
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        private void DeletionMethod()
        {
            Console.Clear();
            Console.WriteLine("Which list would you like to delete from? \n1) Gas Vehicles \n2) Hybrid Vehicles \n3) Electric Vehicles \n");
            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    List<Vehicle> gasList = _repo.GetGasList();
                    foreach (Vehicle vehicle in gasList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich item would you like to remove?");
                    int gasVehicleRemovalMatch = int.Parse(Console.ReadLine());
                    _repo.RemoveSpecificItemFromGasList(gasVehicleRemovalMatch);
                    Console.ReadKey();
                    break;
                case 2:
                    List<Vehicle> hybridList = _repo.GetHybridList();
                    foreach (Vehicle vehicle in hybridList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich item would you like to remove?");
                    int hybridVehicleRemovalMatch = int.Parse(Console.ReadLine());
                    _repo.RemoveSpecificItemFromGasList(hybridVehicleRemovalMatch);
                    Console.ReadKey();
                    break;
                case 3:
                    List<Vehicle> electricList = _repo.GetGasList();
                    foreach (Vehicle vehicle in electricList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.WriteLine("\nWhich item would you like to remove?");
                    int electricVehicleRemovalMatch = int.Parse(Console.ReadLine());
                    _repo.RemoveSpecificItemFromGasList(electricVehicleRemovalMatch);
                    Console.ReadKey();
                    break;
                case 4:
                    PrintList();
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        
        public void PrintList()
        {
            Console.Clear();
            List<Vehicle> masterList = new List<Vehicle>();
            List<Vehicle> gasList = _repo.GetGasList();
            List<Vehicle> hybridList = _repo.GetHybridList();
            List<Vehicle> electricList = _repo.GetElectricList();

            Console.WriteLine("Which list would you like to print? \n1) Master List \n2) Gas Vehicles \n3) Hybrid Vehicles \n4) Electric Vehicles \n");
            int userSelection = int.Parse(Console.ReadLine());

            switch (userSelection)
            {
                case 1:
                    masterList.Concat(gasList).Concat(hybridList).Concat(electricList);
                    foreach (Vehicle vehicle in masterList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    _repo.GetGasList();
                    foreach (Vehicle vehicle in gasList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    foreach (Vehicle vehicle in hybridList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    foreach(Vehicle vehicle in electricList)
                    {
                        Console.WriteLine($"VIN# ({vehicle.VehicleID}) -- {vehicle.Make} -- {vehicle.Type} -- {vehicle.NumberOfDoors} door-- {vehicle.IsRed}");
                    }
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
    }
}
