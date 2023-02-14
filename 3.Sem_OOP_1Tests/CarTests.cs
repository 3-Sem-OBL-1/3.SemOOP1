using Microsoft.VisualStudio.TestTools.UnitTesting;
using _3.Sem_OOP_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Sem_OOP_1.Tests
{
    [TestClass()]
    public class CarTests
    {
        private readonly Car car = new Car() { Id = 0, Model = "Volvo", Price = 50000, LicensePlate = "AC34175"};
        private readonly Car carWithNullModel = new Car() { Id = 0, Model = null, Price = 50000, LicensePlate = "AC34175" };
        private readonly Car carWithEmptyModel = new Car() { Id = 0, Model = "", Price = 50000, LicensePlate = "AC34175" };
        private readonly Car carWithNegativPrice = new Car() { Id = 0, Model = "Volvo", Price = -50000, LicensePlate = "AC34175" };
        private readonly Car carWithTooShortLicense = new Car() { Id = 0, Model = "Volvo", Price = 50000, LicensePlate = "A" };
        private readonly Car carWithTooLongLicense = new Car() { Id = 0, Model = "Volvo", Price = 50000, LicensePlate = "AC341754" };

        [TestMethod()]
        public void ValidateModelTest()
        {
            car.ValidateModel();
            Assert.ThrowsException<ArgumentNullException>(() => carWithNullModel.ValidateModel());
            Assert.ThrowsException<ArgumentException>(() => carWithEmptyModel.ValidateModel());
        }

        [TestMethod()]
        public void ValidatePriceTest()
        {
            car.ValidatePrice();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carWithNegativPrice.ValidatePrice());
        }

        [TestMethod()]
        public void ValidateLicensePlateTest()
        {
            car.ValidateLicensePlate();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carWithTooShortLicense.ValidateLicensePlate());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => carWithTooLongLicense.ValidateLicensePlate());
        }

        [TestMethod()]
        public void ToStringTest()
        {
            string str = car.ToString();
            Assert.AreEqual(car.ToString(), str);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            car.Validate();
        }
    }
}