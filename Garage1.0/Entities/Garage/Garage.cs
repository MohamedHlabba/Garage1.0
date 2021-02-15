using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicule
    {


        private T[] vehicules;
        public int Capacity { get; set; }
       
       

       ConsoleUI ui = new ConsoleUI();


        public bool IsFull => Capacity <= CountVehicule();
       


        public Garage(int capacity)
        {

            Capacity = capacity;
            vehicules = new T[Capacity];

        }


        public IEnumerator<T> GetEnumerator()
        {

            {
                foreach (T item in vehicules)
                {
                    if (item != null)
                    {
                        yield return item;
                    }
                }
            }

        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();




        public bool Add(T item)


        {


           
            
                for (int i = 0; i < vehicules.Length; i++)
                {

                if (IsFull)
                {
                    return IsFull;
                }
                
                
                if (vehicules[i] == null)
                    {
                        vehicules[i] = item;
                        return true;
                    }
                }

                return false;
            

        }
       





        public int CountVehicule()
        {
            int count = 0;
            for (int i = 0; i < vehicules.Length; i++)
            {
                if (vehicules[i]!=null)
                {
                    count++;

                }

            }
            return count;
        }

     


        public T Remove(int i)
        {


           


                var tmp = new T[vehicules.Length];

                for (var j = 0; j < i; ++j)
                {
                    tmp[j] = vehicules[j];
                }

                var result = vehicules[i];

                for (var j = i + 1; j < vehicules.Length - 1; ++j)
                {
                    tmp[j] = vehicules[j];
                }

                
                vehicules = null;

                vehicules = tmp;
                return result;
            
        }

        

    }
}

   



