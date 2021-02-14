using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class Airplane : Vehicule
    {

        private int numberofseats;
        private int lenght;
        public int NumberOfSeats { get; set; }
        public int Length { get; set; }

        public Airplane(string registernummer, string brand, string color, int numberofwheels, int numberofseats, int length) : base(registernummer, brand, color, numberofwheels)
        {

            NumberOfSeats = numberofseats;
            Length = length;

        }

        public override string Stats()
        {
            return base.Stats() + $" Number of seats : {NumberOfSeats} the length is {Length}";
        }

        public override string ToString()
        {
            return "This is a airplane";
        }


    }

}
