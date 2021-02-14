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

  

        public void Addc<T>(T item)
        {


            
          
            garage.Add( item as Vehicule);
           
            
        }



        public void Add<T>(T item ,string name)
        {

          
            //TODO
          
            bool has = garage.Any(ve=>ve.RegisterNummer.EqualsInsensitive(name));

           

            if (has)
                {

                    ui.Print("vehicule exists already with that registernumber");
                     return;
                    
                }
            if (garage.IsFull ==true)
            {
                ui.Print(" Sorry, Garage is full ");
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

    }
    
}




       

      

     
   
       

        




      
      
   
