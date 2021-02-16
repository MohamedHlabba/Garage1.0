using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Garage1._0
{
    public class Manager
    {

        public Handler handler = new Handler();
        public static ConsoleUI ui = new ConsoleUI();
       // public Garage<Vehicule> garage= new Garage<Vehicule>(20);



        public void Start()
        {
            do
            {
                Initialize();


            } while (true);
        }

        public void Initialize()
        {
            ShowMenu();

            UserAction();

        }

        private void UserAction()
        {
            var capacity = Extensions.AskForInt("Sätta en kapacitet ", ui);

            handler.garage = new Garage<Vehicule>(capacity);
            ui.Print("Populera Garaget med ett antal fordon ? Tryck Ja, Nej ");

            var nav = ui.GetInput();
            string yes = "Ja";
            string no = "Nej";
            nav.EqualsInsensitive(yes);
            nav.EqualsInsensitive(no);
            switch (nav)
            {
                case "Ja":
                    Populate();
                    ui.Print("Yes you get some vehicules");
                    handler.Navigate();
                    break;
                case "Nej":
                    handler.Navigate();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    ui.Print("Please Enter a choice from the list up to start using the app");
                    break;
            }

        }


        private static void ShowMenu()
        {
            ui.Print("Welcome to the Garage\n(1, 2, 0) "
                                        + "\n1.Sätta en kapacitet för att starta "
                                        + "\n0.Exit the application");
            ui.GetInput();
        }

        public void Populate()
        {
            Car c1 = new Car("SE147", "Tesla", "Black", 4, "EL");
            Car c2 = new Car("FR145", "Tesla", "Beige", 4, "Diesel");
            MotorCycle mt1 = new MotorCycle("XN221", "Suzuki", "Black", 2, 250);
            MotorCycle mt2 = new MotorCycle("XBG21", "Yamaha", "Black", 2, 1200);
            Boat b1 = new Boat("DR458", "Boston Whaler ", "White", 3, 8);
            Airplane air1 = new Airplane("CZF159", "Cessna", "White", 3, 4, 8);
            Airplane air2 = new Airplane("CZFK9", "Yamaha", "White", 3, 4, 8);
            Bus bus1 = new Bus("FZE126", "Volvo", "Red", 6, 50, 11);
            if (handler.garage.IsFull == false)
            {

               handler.garage.Add(c1);
                handler.garage.Add(c2);
                handler.garage.Add(mt1);
                handler.garage.Add(mt2);
                handler.garage.Add(b1);
                //handler.garage.Add(air2);
                //handler.garage.Add(air1);
                //handler.garage.Add(bus1);
            }

            string strResultJson = JsonConvert.SerializeObject(handler.garage.GetEnumerator());
            Console.WriteLine(strResultJson);
            File.WriteAllText(@"Garage.json", strResultJson);
            ui.Print("Stored");

            strResultJson = String.Empty;
            strResultJson = File.ReadAllText(@"garage.json");
            var des = (Vehicule)Newtonsoft.Json.JsonConvert.DeserializeObject(strResultJson, typeof(Vehicule));
            var resultGarage = des.ToString();
            //var des2 = JsonConvert.DeserializeObject(strResultJson, typeof(Garage<Vehicule>));
            //var resultGarage2 = des2.ToString();
           
            var dictionary = JsonConvert.DeserializeObject<IDictionary>(strResultJson);

            foreach (DictionaryEntry entry in dictionary)
            {
                ui.Print(entry.Key + ":" + entry.Value);
            }




        }

    }
}










































