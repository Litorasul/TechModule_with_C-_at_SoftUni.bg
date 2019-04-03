using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    class VehicleCatalogue
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            List<Vehicle> cars = new List<Vehicle>();
            List<Vehicle> trucks = new List<Vehicle>();
            List<Vehicle> allVehicles = new List<Vehicle>();

            while (input[0] != "End")
            {
                if (input[0] == "truck")
                {
                    var theTruck = new Vehicle(input[0], input[1], input[2], int.Parse(input[3]));
                    trucks.Add(theTruck);
                    allVehicles.Add(theTruck);
                }
                else if (input[0] == "car")
                {
                    var theCar = new Vehicle(input[0], input[1], input[2], int.Parse(input[3]));
                    cars.Add(theCar);
                    allVehicles.Add(theCar);
                }
                input = Console.ReadLine().Split().ToList();
            }
            string carToPrint = Console.ReadLine();

            while (carToPrint != "Close the Catalogue")
            {
                Vehicle vehicle = allVehicles.Find(x => x.Model == carToPrint);
                Console.WriteLine(vehicle.ToString());
                carToPrint = Console.ReadLine();
            }

            SumAndPrint(trucks, cars);
         
        }

        private static void SumAndPrint(List<Vehicle> trucks, List<Vehicle> cars)
        {
            double sumTrucks = 0.00;
            int trucksCount = 0;
            for (int i = 0; i < trucks.Count; i++)
            {
                sumTrucks += trucks[i].Horsepower;
                trucksCount++;
            }
            double sumCars = 0.00;
            int carCount = 0;
            for (int i = 0; i < cars.Count; i++)
            {
                sumCars += cars[i].Horsepower;
                carCount++;
            }
            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {sumCars / carCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (trucksCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {sumTrucks / trucksCount:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
            
            
        }
    }

    public class Vehicle
    {
        public string Type;
        public string Model;
        public string Colour;
        public int Horsepower;

        public Vehicle()
        {
        }

        public Vehicle(string type, string model, string colour, int horsepower)
        {
            type = FirstToUpper(type); 

            Type = type;
            Model = model;
            Colour = colour;
            Horsepower = horsepower;
        }

        private string FirstToUpper(string type)
        {
            if (String.IsNullOrEmpty(type))
            {
                return null;
            }
            return type.First().ToString().ToUpper() + string.Join("", type.Skip(1));
        }

        public override string ToString()
        {
            string toPrint = $"Type: {Type}"
                + Environment.NewLine
                + $"Model: {Model}"
                + Environment.NewLine
                + $"Color: {Colour}" 
                + Environment.NewLine
                + $"Horsepower: {Horsepower}";
            return toPrint;
        }
    }
}
