using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
  public  class Vehicule
    {

        private string registernummer;
        private string color;
        private int numbersofwheels;
        private string brand;
        
        

        public string RegisterNummer { get; set; }

        public  string Color { get; set; }
        public int NumberOfWheels { get; set; }

        public string Brand { get; set; }

       


        public Vehicule( string registernummer,string brand,string color,int numberofwheels)
        {
            RegisterNummer = registernummer;
            Brand = brand;
            Color = color;
            NumberOfWheels = numberofwheels;


        }
        public virtual string Stats()
        {
            return $"Vehicule Description:" +
                $" Type:{GetType().Name} " +
                $" RegistrationNumber :{RegisterNummer}" +
                $" Brand :{Brand} " +
                $" Color :{Color} " +
                $" Number of wheels :{NumberOfWheels} ";
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Vehicule))
                return false;
            else
                return RegisterNummer == ((Vehicule)obj).RegisterNummer;
            
        }



      

    }
}

