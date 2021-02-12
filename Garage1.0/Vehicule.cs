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
       


        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Vehicule))
                return false;
            else
                return RegisterNummer == ((Vehicule)obj).RegisterNummer;
            
        }

         

        
        

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




        public class Airplane :Vehicule
        {

            private int numberofseats;
            private int lenght;
            public int NumberOfSeats { get; set; }
            public int Length { get; set; }

            public Airplane( string registernummer, string brand, string color, int numberofwheels,int numberofseats,int length) : base(registernummer, brand, color, numberofwheels)
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
     public   class Car :Vehicule
        {
            private string fueltype;
            public string FuelType { get; set; }

            public Car( string registernummer, string brand, string color, int numberofwheels,string fueltype) : base(registernummer, brand, color, numberofwheels)
            {


                FuelType = fueltype;
            }


            public override string Stats()
            {
                return base.Stats()+$"FuelType is {FuelType}";
            }


            public override string ToString()
            {
                return $"this is a car ";
            }
        }

     public   class MotorCycle : Vehicule
        {
            private int cylindervolum;
            public int CylinderVolum { get; set; }

            public MotorCycle(string registernummer, string brand, string color, int numberofwheels,int cylindervolum) : base(registernummer, brand, color, numberofwheels)
            {
                CylinderVolum = cylindervolum;
            }

            public override string Stats()
            {
                return base.Stats()+$"CylinderVolum is :{CylinderVolum}";
            }
            public override string ToString()
            {
                return "This is a moto";
            }

        }

      public  class Bus : Vehicule
        {
            private int numberofseat;
            private int lenght;
            public int NumberOfSeats { get; set; }

            public int Length { get; set; }

            public Bus(string registernummer, string brand, string color, int numberofwheels,int numberofseats,int length) : base(registernummer, brand, color, numberofwheels)
            {
                NumberOfSeats = numberofseats;
                Length= length;
            }

            public override string Stats()
            {
                return base.Stats()+$"Number of seat {NumberOfSeats} the length {Length}";
            }
            public override string ToString()
            {
                return "This is a bus";
            }

        }

      public  class Boat: Vehicule
        {
            private int numberofengines;
            public int NumberOfEngines { get; set; }

            public Boat( string registernummer, string brand, string color, int numberofwheels,int numberofengines) : base(registernummer, brand, color, numberofwheels)
            {

                NumberOfEngines = numberofengines;
            }


            public override string Stats()
            {
                return base.Stats()+$"{NumberOfEngines} engine";
            }
            public override string ToString()
            {
                return "This is a boat";
            }
        }




    }
}


//for (int i = 0; i < vehicules.Length; i++)
//{
//    if (vehicules[i] == null)
//    {
//        vehicules[i] = item;
//        return true;
//    }

//    else if (IsFull || item is null) return false;
//    ui.Print("Garage is full");

//}