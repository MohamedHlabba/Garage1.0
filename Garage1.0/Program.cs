using System;

namespace Garage1._0
{
    class Program
    {



        
         //static   GarageManager manager = new GarageManager();
      static   ConsoleUI ui = new ConsoleUI();
      static  Manager manager = new Manager();

        static void Main(string[] args)
        {
  



            do
            {
                // ShowMenu();
                // UserAction();
                // manager.Inialiaze();
                manager.Start();
               

            } while (true);
        }

        //private static void ShowMenu()
        //{
        //    ui.Print("Welcome to the Garage\n(1, 2, 3, 4, 5, 0) "
        //                        + "\n1. Lista samtliga parkerade fordon"
        //                        + "\n2. Lista fordonstyper och hur många av varje som står i garaget"
        //                        + "\n3. Lägga till och ta bort fordon ur garaget"
        //                        + "\n4. Hitta ett specifikt fordon via registreringsnumret."
        //                        + "\n5. Söka efter fordon utifrån en  egenskap eller flera  "
        //                        + "\n0. Exit the application");
        //}

        //private static void UserAction()    
        //{
        //    char input = ' ';
        //    try
        //    {
        //        input = ui.GetInput()[0]; //Tries to set input to the first char in an input line
        //    }
        //    catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
        //    {
        //        Console.Clear();
        //        ui.Print("Please enter some input!");
        //    }
        //    switch (input)
        //    {
        //        case '1':
        //            manager.GettAllVehicules();
        //            break;
        //        case '2':
        //            //TODO
        //            manager.ByType();
        //            break;
        //        case '3':
        //            manager.AddVehicuke();
        //            break;
        //        case '4':
        //            manager.GetVehiculeByRegNumber();
        //            break;
        //        case '5':
        //            manager.SearchByFilter();
        //            break;

        //        case '0':
        //            Environment.Exit(0);
        //            break;
        //        default:
        //            Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
        //            break;
        //    }
        //}
    }  }
