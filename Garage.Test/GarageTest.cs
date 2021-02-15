using Garage1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Garage.Test
{
  
    [TestClass]
    public  class GarageTest
    {


        public TestContext TestContext { get; set; }
        private Garage<Vehicule> Array;

        [ClassInitialize]

        public static void ClassSetUp(TestContext context)
        {
            //Once / Class


        }
        [TestInitialize]
        public void SetUP()
        {
            if (TestContext.TestName.EndsWith('0'))
                Array = new Garage<Vehicule>(0);
            else
                Array = new Garage<Vehicule>(6);
            
        }

        [TestMethod]
        public void Add_WithZeroCapacity_0()
        {

            //Arrange
            const int expected = 0;
            // var Array = new Garage<Vehicule>(expected);

            //Act
            var tryToAdd = Array.Add(new Vehicule("Grf45","Mercedes","Black",2));
            var Count = Array.CountVehicule();
            var actual = Array.Capacity;

            //Assert


            Assert.IsFalse(tryToAdd);
            Assert.AreEqual(Count, expected);
            Assert.AreEqual(actual,expected);
        }

        [TestCleanup]
        public void CleanUP()
        {


        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }


    }
}
