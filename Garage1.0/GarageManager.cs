using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Garage1._0.Vehicule;

namespace Garage1._0
{
    public class GarageManager
    {

        public GarageHandler handler = new GarageHandler();
        ConsoleUI ui = new ConsoleUI();
        






        public void AddVehicuke()
        {

            ui.Print("Choose for the list below to Add a new vehicule");
            ui.Print("Welcome to the Garage\n(1, 2, 3 ,4, 0) "
                    + "\n1. Add Car"
                    + "\n2. Add Airplaine"
                    + "\n3. Add Bus"
                    + "\n4. Add MotorCycle"
                    + "\n5. Add Boat"
                    + "\n6. GetByCategory"
                    + "\n7. GetAll"
                     + "\n8. Remove by regis"
                    + "\n0. Exit the application");
            string nav = ui.GetInput();
            switch (nav)
            {

                case "1":
                    AddCar();
                    break;
                case "2":
                    AddAirplane();
                    break;
                case "3":
                    AddBus();
                    break;

                case "4":
                    AddMotocycle();
                    break;
                case "5":
                    AddBoat();
                    break;

                case "6":
                    SearchByFilter();


                    break;
                case "7":
                    GettAllVehicules();
                    break;
                case "8":
                    // RemoveVehicule();
                    // GetVehiculeByRegNumber();
                    RemoveVehiculeeeeee();
                    break;
                    
                default:
                    ui.Print("Please choose a number from menu");
                    break;


            }
        }

        private void AddBoat()
        {
            string brand4 = Extensions.AskForString("Brand", ui);
            string regs4 = Extensions.AskForString("Registernummer", ui);
            string color4 = Extensions.AskForString("Color", ui);
            int wheels4 = Extensions.AskForInt("Wheels", ui);
            int numberofseat4 = Extensions.AskForInt("Number of engine ", ui);
            var boat = new Boat(regs4, brand4, color4, wheels4, numberofseat4);
            handler.Add(boat);
            
        }
        private void AddMotocycle()
        {
            string brand3 = Extensions.AskForString("Brand", ui);
            string regs3 = Extensions.AskForString("Registernummer", ui);
            string color3 = Extensions.AskForString("Color", ui);
            int wheels3 = Extensions.AskForInt("Wheels", ui);
            int cylinder = Extensions.AskForInt("Cylinder Volume", ui);
            var motor = new MotorCycle(regs3, brand3, color3, wheels3, cylinder);
           
            handler.Add(motor);
          
        }

        private void AddBus()
        {
            string brand2 =Extensions.AskForString("Brand", ui);
            string regs2 = Extensions.AskForString("Registernummer", ui);
            string color2 =Extensions.AskForString("Color", ui);
            int wheels2 = Extensions.AskForInt("Wheels", ui);
            int numberofseat2= Extensions.AskForInt("Number Of seat", ui);
            int length2 = Extensions.AskForInt("Length", ui);
            var bus = new Bus(regs2, brand2, color2, wheels2, numberofseat2, length2);
           handler.Add(bus);
           

        }

        private void AddAirplane()
        {
            string brand1 = Extensions.AskForString("Brand", ui);
            string regst1 = Extensions.AskForString("Registernummer", ui);
            string color1 = Extensions.AskForString("Color", ui);
            int wheels1   = Extensions.AskForInt("Wheels", ui);
         int numberofseat = Extensions.AskForInt("Number Of seat", ui);
            int length    = Extensions.AskForInt("Length", ui);
            var airplane = new Airplane(regst1, brand1, color1, wheels1, numberofseat, length);
           handler.Add(airplane);
           
        }



        private void AddCar4()
        {
            string brand = Extensions.AskForString("Brand", ui);
            string regst = Extensions.AskForString("Registernummer", ui);

            string color = Extensions.AskForString("Color", ui);
            int wheels = Extensions.AskForInt("Wheels", ui);
            string fueltype = Extensions.AskForString("FuelType", ui);
            var car = new Car(regst, brand, color, wheels, fueltype);
            handler.Add(car);

        }

        private void AddCar()
        {
            string brand = Extensions.AskForString("Brand", ui);
            string regst = Extensions.AskForString("Registernummer", ui);



            string color = Extensions.AskForString("Color", ui);
            int wheels = Extensions.AskForInt("Wheels", ui);
            string fueltype = Extensions.AskForString("FuelType", ui);
            var car = new Car(regst, brand, color, wheels, fueltype);
            handler.Adcd(car, regst);

        }

        public void GettAllVehicules()
        {
            foreach (Vehicule vehicule in handler.GetAll<Vehicule>())
            { 
                ui.Print($"{vehicule.Stats()}");
            }
        }

        public void RemoveVehiculeeeeee()
        {
           
            var checkReg = Extensions.AskForString("Register number", ui);

            var query = from Vehicule vehicule in handler.garage
                        where vehicule.RegisterNummer == checkReg
                        select vehicule ;
            foreach (var item in query)
            {
                
            int index = Extensions.FindIndex(handler.garage.ToArray(), item);
               handler.Remove(index);  
            }
           
               ui.Print("Vehicule has been removed");

           
          
        }

            public void RemoveVehicule()
        {

            var checkReg = Extensions.AskForString("Register number", ui);
            var query = from Vehicule vehicule in handler.garage
                        where vehicule.RegisterNummer==checkReg
                        select vehicule;
           // handler.Remove(query);

            //foreach ( s in query)
            //    Console.WriteLine(s.LastName + ": " + s.Scores[0]);
            ui.Print("Enter vehicule's registernummer to remove it from the list");
            

            var resultat = handler.garage.ToList().Where( val=> val.RegisterNummer.ToLower()!=checkReg).ToArray();
            // resultat.ToList().IndexOf(handler.garage.Where(val => val.RegisterNummer.ToLower() != checkReg));
           // int x = Extensions.FindIndex(handler.garage, handler.garage.ToList().Where(val => val.RegisterNummer.ToLower() != checkReg).ToArray());
            foreach (var item in resultat)
            {
                ui.Print(item.Stats());
            }
            //handler.garage.

            // handler.garage = handler.garage.Where(e => e.CompareTo(reg) != 0).ToArray();
            //string[] arrayOfItems = new string[5] { "Apple", "Banana", "Orange", "Apple", "Grape" };

            //var arrayWithoutApples = arrayOfItems.Where(x => x != "Apple").ToArray();

            //foreach (var item in arrayWithoutApples)
            //{
            //    Console.WriteLine(item);
            //}



        }

        public void GetVehiculeByRegNumber()
        {
            var regs = Extensions.AskForString("Enter the registernumber  ",ui);
            handler.garage.Where(v => v.RegisterNummer.ToLower() == regs).  
            ToList().
             ForEach(v => ui.Print(v.Stats()));

        }


        public void SearchByFilter()
        {

            ui.Print("Here You can filter Vehicules by " +
                "\n1.  Color " +
                "\n2.  Brand " +
                "\n3.  Number of engines ");

           
           // var checkType = ui.GetInput().ToLower();

            var nav = ui.GetInput();
            switch (nav)

            {

                case "1":
                    ui.Print("What color ?");
                    var checkcolor = ui.GetInput().ToLower();
                  handler.garage.Where(v=>v.Color.ToLower()==checkcolor).
                  ToList().ForEach(v => ui.Print(v.Stats()));
                    break;
                case "2":
                   
                    var checknumberwheels = Extensions.AskForInt("How many wheels ?", ui);
                    handler.garage.Where(v => v.NumberOfWheels == checknumberwheels).
                    ToList().ForEach(v => ui.Print(v.Stats()));
                    //   var checkbyNumberOfwheels = Extensions.AskForInt("How many wheels ? : ",ui);
                    //handler.garage.Select(p => p.NumberOfWheels ==checkbyNumberOfwheels )
                    //   .ToList().ForEach(p => Console.WriteLine());
                    break;
                case "3":
                    ui.Print("What brand ?");
                    var brand = ui.GetInput().ToLower();
                    handler.garage.Where(v => v.Brand == brand).
                    ToList().ForEach(v=> ui.Print(v.Stats()));

                    break;

                default:
                    break;
            }

                





            //handler.garage.Where(p=> p.GetType().Name.ToLower() == checkType)
            //    .ToList().ForEach(p=> Console.WriteLine(p.Stats()));

           
            //filtrera via fueltype
            //handler.garage.OrderBy(p => p.NumberOfWheels).ToList().ForEach(p => Console.WriteLine(p.Stats()));


            //foreach (Vehicule v in res)
            //{
            //    ui.Print(v.Stats());
            //}


            //ForEach(e => Console.WriteLine(e.ToString()));




            //foreach (var item in results)
            //{
            //    ui.Print(item.ToString());
            //}



            //var query = from item in handler.garage
            //            group item by item.GetType() into y
            //            select new { key = y.Key,grouping = y };


            //foreach (var g in query)
            //{
            //    //this is each grouping
            //    foreach (var item in query)
            //    {
            //        //this is each item in each group
            //        ui.Print(item.ToString());
            //    }
            //}


            //handler.garage.GroupBy(p=> p.Color).ToList().ForEach(p => Console.WriteLine(p.ToString()));




            ////foreach (Vehicule item in handler.garage)
            ////{
            ////    ui.Print(item.Stats());
            ////}


        }
    }
}

