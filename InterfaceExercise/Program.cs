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
            List<IVehicle> vehicles = new List<IVehicle>();
            var car = new Car();
            vehicles.Add(car);
            var truck = new Truck() { NumberOfSeats = 3, TruckBed = true, Catagory = "Big Ol Truck", Logo = "TRUCK", Make = "Ford", Model = "F250", Year = "2007" };
            vehicles.Add(truck);
            var suv = new SUV();
            vehicles.Add(suv);
            foreach (var veh in vehicles)
            {
                if (veh.GetType() == car.GetType())
                {
                    Console.WriteLine($"{car.Year} {car.Make} {car.Model}. Logo: {car.Logo}. Type: {car.Catagory}.");
                    Console.WriteLine($"Has back seats? {car.BackSeats}. Number of Seats: {car.NumberOfSeats}");
                }
                else if (veh.GetType() == truck.GetType())
                {
                    Console.WriteLine($"{truck.Year} {truck.Make} {truck.Model}. Logo: {truck.Logo}. Type: {truck.Catagory}.");
                    Console.WriteLine($"Has Truck Bed? {truck.TruckBed}. Number of Seats: {truck.NumberOfSeats}");
                }
                else
                {
                    Console.WriteLine($"{suv.Year} {suv.Make} {suv.Model}. Logo: {suv.Logo}. Type: {suv.Catagory}.");
                    Console.WriteLine($"Has third row of Seats? {suv.ThirdRowSeats}. Number of Seats: {suv.NumberOfSeats}");
                }
                veh.Drive();
            }

        }
    }
}
