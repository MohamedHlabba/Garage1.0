using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Garage1._0.Vehicule;

namespace Garage1._0
{



    public class GarageHandler : IHandler
    {

        ConsoleUI ui = new ConsoleUI();
        // public Garage<Vehicule> garage = new Garage<Vehicule>(capacity: 10);
        public Garage<Vehicule> garage;
            //new Garage<Vehicule>();

        //public void intialize()
        //{
        //    var capacity = Extensions.AskForInt("Capacity", ui);
        //    garage = new Garage<Vehicule>(capacity);
        //}



        public void Addtest<Vehicule>(Vehicule v)
        {

                if (garage.IsFull == true)
                {
                    ui.Print(" Sorry, Garage is full ");
                    return;
                }

                ui.Print("Choose for the list below to Add a new vehicule");
            ui.Print("Welcome to the Garage\n(1, 2, 3 ,4, 0) "
                    + "\n1. Add Car"
                    + "\n2. Add Airplaine"
                    + "\n3. Add Bus"
                    + "\n4. Add MotorCycle"
                    + "\n5. Add Boat");
                     
                string nav = ui.GetInput();
                switch (nav)
                {



                case "1":
                    string regst = Extensions.AskForString("Registernummer", ui);
                    bool has1 = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regst));

                    if (has1)
                    {

                        ui.Print("vehicule exists already with that registernumber");
                        return;

                    }

                    string brandc = Extensions.AskForString("Brand", ui);
                    string colorc = Extensions.AskForString("Color", ui);
                    int wheelsc = Extensions.AskForInt("Wheels", ui);
                    string fueltype = Extensions.AskForString("FuelType", ui);
                    var car = new Car(regst, brandc, colorc, wheelsc, fueltype);
                    garage.Add(car);
                    ui.Print("You add a new Car");

                    break;


                    case "2":

            string regs3 = Extensions.AskForString("Registernummer", ui);
            bool has = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regs3));

            if (has)
            {

                ui.Print("vehicule exists already with that registernumber");
                return;

            }

                string brand3 = Extensions.AskForString("Brand", ui);
                string color3 = Extensions.AskForString("Color", ui);
                int wheels3 = Extensions.AskForInt("Wheels", ui);

                int cylinder = Extensions.AskForInt("Cylinder Volume", ui);
                var motor = new MotorCycle(regs3, brand3, color3, wheels3, cylinder);
                garage.Add(motor);


                ui.Print($"You add a new  Motocycle");
                    break;
                    case "3":
                    string regs = Extensions.AskForString("Registernummer", ui);
                    bool has2 = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regs));

                    if (has2)
                    {

                        ui.Print("vehicule exists already with that registernumber");
                        return;

                    }

                    string brand = Extensions.AskForString("Brand", ui);
                    string color = Extensions.AskForString("Color", ui);
                    int wheels= Extensions.AskForInt("Wheels", ui);
                    int numberofseat = Extensions.AskForInt("Number Of seat", ui);
                    int length = Extensions.AskForInt("Length", ui);
                    var airplane = new Airplane(regs, brand, color, wheels, numberofseat, length);
                    garage.Add(airplane);
                    ui.Print($"You add a new  Airplane ");

                    break;
                    case "4":
                    string regs2 = Extensions.AskForString("Registernummer", ui);

                    bool has3 = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regs2));

                    if (has3)
                    {

                        ui.Print("vehicule exists already with that registernumber");
                        return;

                    }

                    string brand2 = Extensions.AskForString("Brand", ui);
                    string color2 = Extensions.AskForString("Color", ui);
                    int wheels2 = Extensions.AskForInt("Wheels", ui);
                    int numberofseat2 = Extensions.AskForInt("Number Of seat", ui);
                    int length2 = Extensions.AskForInt("Length", ui);
                    var bus = new Bus(regs2, brand2, color2, wheels2, numberofseat2, length2);
                    garage.Add(bus);
                    ui.Print($"You add a new Bus ");

                    break;

                case "5":
                    string regs4 = Extensions.AskForString("Registernummer", ui);
                    bool has4 = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regs4));

                    if (has4)
                    {

                        ui.Print("vehicule exists already with that registernumber");
                        return;

                    }

                    string brand4 = Extensions.AskForString("Brand", ui);
                    string color4 = Extensions.AskForString("Color", ui);
                    int wheels4 = Extensions.AskForInt("Wheels", ui);
                    int numberofseat4 = Extensions.AskForInt("Number of engine ", ui);
                    var boat = new Boat(regs4, brand4, color4, wheels4, numberofseat4);
                    garage.Add(boat);
                    ui.Print($"You add a new Boat ");

                    break;


                    


                    default:
                        ui.Print("Please choose a number from menu");
                        break;


                }
            }











            //TODO




        public void Add<T>(T item, string name)
        {


            if (garage.IsFull == true)
            {
                ui.Print(" Sorry, Garage is full ");
                return;
            }
            //TODO

            bool has = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(name));



            if (has)
            {

                ui.Print("vehicule exists already with that registernumber");
                return;

            }

            garage.Add(item as Vehicule);

            ui.Print($"You add a new  {item.GetType().Name} ");

        }



        public IEnumerable GetAll<T>()
        {
            if (garage.CountVehicule() == 0)
                ui.Print("GArage IS empty");
            return garage;

        }

        public IEnumerable GEttbyCategory<T>()
        {
            return garage;
        }

        public void Remove(int i)
        {

            garage.Remove(i);


        }

        public void Addc<T>(T item)
        {
            throw new NotImplementedException();
        }
    }


}




       

      

     
   
       

        




      
      
   
