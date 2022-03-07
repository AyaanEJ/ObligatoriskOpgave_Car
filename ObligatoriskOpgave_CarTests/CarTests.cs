using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoriskOpgave_Car;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave_CarTests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;

        [TestInitialize]
        public void Setup()
        {
            _car = new Car(1, "Astra", 220000, "YZ42349");
        }

        [TestMethod()]
        public void TestConstructor()
        {
            Car c1 = new Car(1, "Astra", 220000, "YZ42349");

            Assert.AreEqual(1, c1.id);
            Assert.AreEqual("Astra", c1.Model);
            Assert.AreEqual(220000, c1.Price);
            Assert.AreEqual("YZ42349", c1.LicensePlate);
        }

        [TestMethod()]
        public void TestModel()
        {
            _car._model = "Astra";
            Assert.AreEqual("Astra", _car.Model);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
            Assert.ThrowsException<ArgumentException>(() => _car.Model = "A");
        }

        [TestMethod()]
        public void TestPrice()
        {
            Assert.AreEqual(220000, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = 0);
        }
        [TestMethod()]
        public void TestLicensePlate()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "A");
            Assert.AreEqual("YZ42349", _car.LicensePlate);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.LicensePlate = "BV89435JKL");
        }
    }
}