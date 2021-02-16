using GarageApp;
using GarageApp.Vehicles;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace GarageTest
{
    [TestClass]
    public class GarageTest
    {
        [TestMethod]
        public void CreateGarage_()
        {
            // Arrange
            const int expected = 16;
            var garage = new Garage<Vehicle>(expected);
            // Act
            int actual = garage.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Size of Garage is 0 or negative.")]
        public void CreateGarage_NegativeCapacity_ShouldThrowException()
        {
            var garage = new Garage<Vehicle>(-1);
        }

        [TestMethod]
        public void CreateGarage_Capacity1_()
        {
            // Arrange
            const int expected = 1;
            var garage = new Garage<Vehicle>(expected);
            // Act
            int actual = garage.Capacity;
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}

