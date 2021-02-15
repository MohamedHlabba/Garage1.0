using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    public class MotorCycle : Vehicule
    {
        private int cylindervolum;
        public int CylinderVolum { get; set; }

        public MotorCycle(string registernummer, string brand, string color, int numberofwheels, int cylindervolum) : base(registernummer, brand, color, numberofwheels)
        {
            CylinderVolum = cylindervolum;
        }

        public override string Stats()
        {
            return base.Stats() + $"CylinderVolum is :{CylinderVolum}";
        }
        public override string ToString()
        {
            return "This is a moto";
        }

    }
}