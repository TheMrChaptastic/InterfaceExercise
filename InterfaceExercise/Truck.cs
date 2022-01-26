using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
            CarLot.TrucksInLot.Add(this);
        }
        public int NumberOfSeats { get; set; } = 4;
        public bool TruckBed { get; set; } = true;
        public string Model { get; set; } = "F150";
        public string Year { get; set; } = "1999";
        public string Catagory { get; set; } = "Truck";
        public string Make { get; set; } = "Ford";
        public string Logo { get; set; } = "Ford";
        public void Drive()
        {
            Console.WriteLine("Vroooom Vroooom");
            Console.WriteLine();
        }
    }
}
