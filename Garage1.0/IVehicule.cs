using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1._0
{
    interface IVehicule
    { 
    //{ public void Add(Vehicule v);
    //    public void Delete(Vehicule v);

        public void FindByType(string reg);
        public void SearchFordon();
    }
}
