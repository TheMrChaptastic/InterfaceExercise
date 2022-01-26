using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int NumberOfSeats { get; set; } = 5;
        public bool BackSeats { get; set; } = true;
        public string Model { get; set; } = "350Z";
        public string Year { get; set; } = "2012";
        public string Catagory { get; set; } = "Sport";
        public string Make { get; set; } = "Nissan";
        public string Logo { get; set; } = "Nissan";
        public void Drive()
        {
            Console.WriteLine("vroom vroom");
            Console.WriteLine();
        }
    }
}
