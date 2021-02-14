
using System.Collections;
using System.Linq;

namespace Garage1._0
{
    public interface IHandler
    {


      //public int FindIndex<T>(T[] array, T item);

       public void Add<T>(T item , string reg);

     

        public IEnumerable GetAll<T>();

        public IEnumerable GEttbyCategory<T>();

        public  void Remove(int i);


        
       




    }
}
