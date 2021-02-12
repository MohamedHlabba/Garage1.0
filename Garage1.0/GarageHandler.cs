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
        public Garage<Vehicule> garage = new Garage<Vehicule>();

        static bool check;

        public void Add<T>(T item)
        {


            
          
            garage.Add( item as Vehicule);
           
            
        }



        public void Adcd<T>(T item ,string name)
        {

          //  string someString = name;
            //string newString = string.Concat(
            //    someString.ToLower().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToUpper(c)));

            bool has = garage.Any(cus => cus.RegisterNummer.ToLower().Equals(name) || cus.RegisterNummer.ToUpper().Equals(name));
          //  bool has = garage.Any(cus => cus.RegisterNummer.Equals(name.AsEnumerable().SequenceEqual)) || cus.RegisterNummer.ToUpper().Equals(someString));
            //bool has2 = garage.Any(cus => cus.RegisterNummer.CompareTo(name));


            if (has)
                {

                    ui.Print("vehicule exists already with that number");
                     return;
                    
                }
                
                garage.Add(item as Vehicule);

          

        }



        public IEnumerable GetAll<T>()
        {
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

    }
    
}




       

      

     
   
       

        




      
      
   
