using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Test
{

    [TestClass]
   public  class GarageSetUp
    {

        [AssemblyInitialize]
        public static void GarageSetup(TestContext context)
        {


            //Starts here

        }

        [AssemblyCleanup]
        public static void GarageCleanUp()
        {

            //Cleanup

        }


    }


}
