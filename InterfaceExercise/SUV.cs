using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
            CarLot.SUVsInLot.Add(this);
        }
        public int NumberOfSeats { get; set; } = 7;
        public bool ThirdRowSeats { get; set; } = true;
        public string Model { get; set; } = "Yukon";
        public string Year { get; set; } = "2013";
        public string Catagory { get; set; } = "SUV";
        public string Make { get; set; } = "GMC";
        public string Logo { get; set; } = "GMC";
        public void Drive()
        {
            Console.WriteLine("VROOM VROOM");
            Console.WriteLine();
        }
    }
}
