using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class Boat : Vehicule
    {
        private int numberofengines;
        public int NumberOfEngines { get; set; }

        public Boat(string registernummer, string brand, string color, int numberofwheels, int numberofengines) : base(registernummer, brand, color, numberofwheels)
        {

            NumberOfEngines = numberofengines;
        }


        public override string Stats()
        {
            return base.Stats() + $"{NumberOfEngines} engine";
        }
        public override string ToString()
        {
            return "This is a boat";
        }
    }


}
