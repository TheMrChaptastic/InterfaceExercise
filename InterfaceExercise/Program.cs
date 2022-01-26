using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car = new Car();
            var truck = new Truck() { NumberOfSeats = 3, TruckBed = true, Catagory = "Big Ol Truck", Logo = "TRUCK", Make = "Ford", Model = "F250", Year = "2007" };
            var suv = new SUV();
            var newCar = new Car() { BackSeats = false, NumberOfSeats = 21, Catagory = "Family", Logo = "Big Mac", Make = "McDonalds", Model = "Quarter Pounder", Year = "2023" };

            if (CarLot.CarsInLot.Count > 0)
            {
                foreach (var c in CarLot.CarsInLot)
                {
                    Console.WriteLine($"{c.Year} {c.Make} {c.Model}. Logo: {c.Logo}. Type: {c.Catagory}.");
                    Console.WriteLine($"Has back seats? {c.BackSeats}. Number of Seats: {c.NumberOfSeats}");
                    c.Drive();
                }
            }
            if (CarLot.TrucksInLot.Count > 0)
            {
                foreach (var c in CarLot.TrucksInLot)
                {
                    Console.WriteLine($"{truck.Year} {truck.Make} {truck.Model}. Logo: {truck.Logo}. Type: {truck.Catagory}.");
                    Console.WriteLine($"Has Truck Bed? {truck.TruckBed}. Number of Seats: {truck.NumberOfSeats}");
                    c.Drive();
                }
            }
            if (CarLot.SUVsInLot.Count > 0)
            {
                foreach (var c in CarLot.SUVsInLot)
                {
                    Console.WriteLine($"{suv.Year} {suv.Make} {suv.Model}. Logo: {suv.Logo}. Type: {suv.Catagory}.");
                    Console.WriteLine($"Has third row of Seats? {suv.ThirdRowSeats}. Number of Seats: {suv.NumberOfSeats}");
                    c.Drive();
                }
            }

        }
    }
}
