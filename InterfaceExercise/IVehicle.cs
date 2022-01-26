using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public string Catagory { get; set; }
        public void Drive();
    }
}
