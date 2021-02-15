using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class Car : Vehicule
    {
        private string fueltype;
        public string FuelType { get; set; }

        public Car(string registernummer, string brand, string color, int numberofwheels, string fueltype) : base(registernummer, brand, color, numberofwheels)
        {


            FuelType = fueltype;
        }


        public override string Stats()
        {
            return base.Stats() + $"FuelType : {FuelType}";
        }


        public override string ToString()
        {
            return $"this is a car ";
        }
    }
}
