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
        //private int _size { get; set; }
        //public int Count => vehicules.Length;
        private int count;
        static bool check = false;

       ConsoleUI ui = new ConsoleUI();


        public bool IsFull => Capacity <= CountVehicule();

     //public Vehicule this [int index] =>vehicules [index];


        public Garage()
        {
            vehicules = new T[3];
            //Capacity=2;

        }










        //public void GetIndex(int i)
        //{

        //    //Extensions.FindIndex(vehicules,);
        //}

        //public int T GetIndex(Vehic)
        //{

        //    return Array.FindIndex(vehicules, val => val.Equals(v));

        //}



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

        //public bool Remove(T item)
        //{

        //}
        //public bool Add(T item)
        //{
        //    bool test = false;
        //    for (int i = 0; i < vehicules.Length; i++)
        //    {
        //        if (vehicules[i] == null)
        //        {
        //            vehicules[i] =item;
                    
        //        }
                
        //        test =true;
        //        {
                    
        //        }

        //    }
            
        //        foreach (T newitem in vehicules)
        //     {

        //        if (newitem.Equals(item.RegisterNummer) == true && vehicules.Contains(item))

        //        {
        //            test = false;

        //        }
        //        test = true;
        //     }

                
                    

        //    return test;
        //}


        public bool Add(T item)


        {


           
            
                for (int i = 0; i < vehicules.Length; i++)
                {
                    if (vehicules[i] == null)
                    {
                        vehicules[i] = item;
                        return true;
                    }
                }

                return false;
            



            //    if (IsFull)

            //    {

            //        return false;
            //        ui.Print("Garage is full");


            //    }
            //    var temp=  vehicules.ToList();
            //    temp.Add(item);
            //    vehicules.ToArray();

            //     return true;
            //Array.Resize(ref myArray, myArray.Length + 1);
            //myArray[myArray.GetUpperBound(0)] = newValue;

            //for (int i = 0; i < vehicules.Length; i++)
            //{
            //   if (vehicules[i] == null)
            //    {
            //        vehicules[i] = item;

            //        check= true;
            //        ui.Print("Succed ");
                 
            //    }
                
            //    {

            //        if (vehicules[i].RegisterNummer.Equals(item.RegisterNummer))

            //            check = false;
            //     ui.Print("Vehicule exists already ");

            //    }

            //}
            //return check;


        }

        //list.Add(item);
            //return true;
        // if (IsFull || item is null) return false;
        //  public void Remove()
        //  {
        //      int keyIndex = vehicules

        //.Select((v, i) => new { Vehicule= v, Index = i })
        //.FirstOrDefault(x => x.Vehicule.Id)?.Index ?? -1;

        //  }


        public int CountVehicule()
        {
            count = 0;
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

                for (var j = i + 1; j < CountVehicule() - 1; ++j)
                {
                    tmp[j] = vehicules[j];
                }

                
                vehicules = null;

                vehicules = tmp;
                return result;
            
        }

        

    }
}

   



