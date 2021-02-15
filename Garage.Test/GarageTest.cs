using Garage1._0;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Garage.Test
{

    [TestClass]
    public class GarageTest
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
                Array = new Garage<Vehicule>(3);

        }




        [TestMethod]
        public void Add_WithZeroCapacity_0()
        {

            //Arrange
            const int expected = 0;


            //Act
            Vehicule v1 = new Vehicule("Grf45", "Mercedes", "Black", 2);
            var tryToAdd = Array.Add(v1);
            var Count = Array.CountVehicule();
            var actual = Array.Capacity;


            //Assert


            Assert.IsFalse(tryToAdd);
            Assert.AreEqual(Count, expected);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CheckArrayIsFull()
        {



            Vehicule v1 = new Vehicule("Grf45", "Mercedes", "Black", 2);
            Vehicule v2 = new Vehicule("Grf5", "Toyota", "Red", 2);
            Vehicule v3 = new Vehicule("IJK45", "Volvo", "Blue", 2);
            Vehicule v4 = new Vehicule("IJgg45", "BMW", "Black", 2);
            Array.Add(v1);
            Array.Add(v2);
            Array.Add(v3);
            Array.Add(v4);
            var expected = Array.IsFull;



            Assert.IsTrue(expected);
        }


        [TestMethod]
        public void Remove_WithZeroIndex_5()
        {

            Vehicule v1 = new Vehicule("Grf45", "Mercedes", "Black", 2);
            var tryToAdd = Array.Add(v1);

            const int expected2 = 0;
            int index = Extensions.FindIndex(Array.ToArray(), v1);

            var trytodelete = Array.Remove(index);
            Assert.IsNotNull(trytodelete);
            Assert.AreEqual(index, expected2);

        }
        [TestMethod]
        public void GetEnumerator()
        {
            
            Vehicule v1 = new Vehicule("Grf45", "Mercedes", "Black", 2);
            Vehicule v2 = new Vehicule("Grf5", "Toyota", "Red", 2);
            Vehicule v3 = new Vehicule("IJK45", "Volvo", "Blue", 2);
            Vehicule v4 = new Vehicule("IJgg45", "BMW", "Black", 2);
            //Array.Add(v1);
            //Array.Add(v2);
            //Array.Add(v3);
         
            //Array.Add(v4);
         
            Assert.IsTrue(Array.GetEnumerator().MoveNext());

            // Assert.AreEqual(v4, Array.GetEnumerator().MoveNext());

            CollectionAssert.AreEqual( new[] { v2, v1, v3,v4},Array.ToArray() );




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
