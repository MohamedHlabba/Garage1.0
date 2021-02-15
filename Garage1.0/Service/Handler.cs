using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Garage1._0
{



    public class Handler : IHandler
    {

        ConsoleUI ui = new ConsoleUI();


        public Garage<Vehicule> garage;










        public void Navigate()
        {


            do
            {




                ui.Print("Welcome to the Garage\n(1, 2, 3, 4, 5, 0) "
                                        + "\n1. Lista samtliga parkerade fordon"
                                        + "\n2. Lista fordonstyper och hur många av varje som står i garaget"
                                        + "\n3. Lägga till och ta bort fordon ur garaget"
                                        + "\n4. Hitta ett specifikt fordon via registreringsnumret."
                                        + "\n5. Söka efter fordon utifrån en  egenskap eller flera  "
                                        + "\n0. Exit the application");

                string nav = ui.GetInput();
                switch (nav)
                {



                    case "1":

                        GettAllVehicules();
                        break;

                    case "2":
                        ByType();
                        break;
                    case "3":
                        AddAndRemove();
                        break;

                    case "4":
                        GetVehiculeByRegNumber();

                        break;

                    case "5":
                        SearchByFilter();
                        break;


                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        ui.Print("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;



                }
            } while (true);
        }



        public void AddAndRemove()
        {

            if (garage.IsFull == true)
            {
                ui.Print(" Sorry, Garage is full ");
                return;
            }

            ui.Print("Choose for the list below to Add a new vehicule");
            ui.Print("Welcome to the Garage\n(1, 2, 3 ,4, 0) "
                    + "\n1. Add Car"
                    + "\n2. Add MotorCycle"
                    + "\n3. Add Bus"
                    + "\n4. Add Airplane"
                    + "\n5. Add Boat"
                     + "\n6. Remove Vehicule");

            string nav = ui.GetInput();
            switch (nav)
            {



                case "1":
                    AddCar();

                    break;


                case "2":
                    AddMoto();


                    break;
                case "3":
                    AddBus();

                    break;
                case "4":
                    AddAirplane();

                    break;

                case "5":
                    AddBoat();

                    break;
                case "6":
                    RemoveVehicule();

                    break;

                default:
                    ui.Print("Please choose a number from menu");
                    break;


            }
        }



        private void AddCar()

        {
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


        }



        private void AddMoto()
        {
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
        }



        private void AddAirplane()
        {
            string regs = Extensions.AskForString("Registernummer", ui);
            bool has2 = garage.Any(ve => ve.RegisterNummer.EqualsInsensitive(regs));

            if (has2)
            {

                ui.Print("vehicule exists already with that registernumber");
                return;

            }

            string brand = Extensions.AskForString("Brand", ui);
            string color = Extensions.AskForString("Color", ui);
            int wheels = Extensions.AskForInt("Wheels", ui);
            int numberofseat = Extensions.AskForInt("Number Of seat", ui);
            int length = Extensions.AskForInt("Length", ui);
            var airplane = new Airplane(regs, brand, color, wheels, numberofseat, length);
            garage.Add(airplane);
            ui.Print($"You add a new  Airplane ");
        }

        private void AddBus()
        {
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

        }

        private void AddBoat()
        {

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

        }

        public void GettAllVehicules()
        {

            if (garage.CountVehicule() == 0)
                ui.Print("GArage IS empty");

            foreach (Vehicule vehicule in garage)
            {


                ui.Print($"{vehicule.Stats()}");
            }
        }




        public void GetVehiculeByRegNumber()
        {
            var regs = Extensions.AskForString("Enter the registernumber  ", ui);
            garage.Where(v => v.RegisterNummer.EqualsInsensitive(regs)).
            ToList().
             ForEach(v => ui.Print(v.Stats()));

        }




        public void RemoveVehicule()
        {


            var result = garage.ToArray();

            if (result.Length == 0)
            {
                ui.Print("Garage is emty");
                return;
            }

            var checkReg = Extensions.AskForString("Register number", ui);

            var query = from Vehicule vehicule in garage
                        where vehicule.RegisterNummer.EqualsInsensitive(checkReg)
                        select vehicule;


            foreach (var item in query)
            {

                int index = Extensions.FindIndex(garage.ToArray(), item);

                garage.Remove(index);

            }
            ui.Print("Vehicule has been removed");
        }


        public void ByType()
        {

            var ofTypeCar = garage.OfType<Car>();

            ui.Print($".{ofTypeCar.Count()} {"Car"} (s)");

            var ofTypeBus = garage.OfType<Bus>();


            ui.Print($".{ofTypeBus.Count()} {"Bus"} (s)");

            var ofTypeM = garage.OfType<MotorCycle>();

            ui.Print($".{ofTypeM.Count()} {"MotorCycle"} (s)");


            var ofTypeAirp = garage.OfType<Airplane>();

            ui.Print($".{ofTypeAirp.Count()} {"Airplane"} (s)");


            var ofTypeB = garage.OfType<Boat>();

            ui.Print($".{ofTypeB.Count()} {"Boat"} (s)");



        }






        public void SearchByFilter()
        {

            ui.Print("Here You can filter Vehicules by " +
                "\n1.  Color " +
                "\n2.  Number of wheels " +
                "\n3.  Brand ");




            var nav = ui.GetInput();
            switch (nav)

            {

                case "1":
                    ui.Print("What color ?");
                    var checkcolor = ui.GetInput();
                    garage.Where(v => v.Color.EqualsInsensitive(checkcolor)).
                    ToList().ForEach(v => ui.Print(v.Stats()));
                    break;
                case "2":

                    var checknumberwheels = Extensions.AskForInt("How many wheels ?", ui);
                    garage.Where(v => v.NumberOfWheels == checknumberwheels).
                    ToList().ForEach(v => ui.Print(v.Stats()));

                    break;
                case "3":
                    ui.Print("What brand ?");
                    var brand = ui.GetInput();
                    garage.Where(v => v.Brand.EqualsInsensitive(brand)).
                    ToList().ForEach(v => ui.Print(v.Stats()));

                    break;

                default:
                    break;
            }



        }


    }
}




