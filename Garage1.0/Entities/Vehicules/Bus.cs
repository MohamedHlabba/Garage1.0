using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class Bus : Vehicule
    {
        private int numberofseat;
        private int lenght;
        public int NumberOfSeats { get; set; }

        public int Length { get; set; }

        public Bus(string registernummer, string brand, string color, int numberofwheels, int numberofseats, int length) : base(registernummer, brand, color, numberofwheels)
        {
            NumberOfSeats = numberofseats;
            Length = length;
        }

        public override string Stats()
        {
            return base.Stats() + $"NbrofSeat:{NumberOfSeats} length :{Length}";
        }
        public override string ToString()
        {
            return "This is a bus";
        }

    }
}
