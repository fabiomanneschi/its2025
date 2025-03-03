using Microsoft.VisualStudio.TestTools.UnitTesting;
using ItsCalcApp;
using System;
using System.ComponentModel;
using System.Threading;

namespace ItsCalcApp.test
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void CalculatorNullTest()
        {
            var calculator = new Calculator();
            //Assert.IsTrue(false);
            Assert.IsNotNull(calculator);
        }

        [TestMethod()]
        public void CalculatorDefaultConstructorTest()
        {
            try
            {
                var calculator = new Calculator();
            }
            catch
            {
                Assert.Fail();
            }

        }

        [TestMethod]
        public void SubtractTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Subtract(1, 1);

            // Assert
            Assert.AreEqual(0, actual);
        }



        [TestMethod]
        [Timeout(1000)]
        [DataRow(1, 2, 3)]
        [DataRow(11, 3, 14)]
        //[DataRow(12, 4, 16)]
        public void AddTest(int a, int b, int ris)
        {
            // Arrange
            var calculator = new Calculator();
            Thread.Sleep(20);

            // Act
            var actual = calculator.Add(a, b);

            // Assert
            Assert.AreEqual(ris, actual);
        }

        [TestMethod]
        public void MultiplyTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Multiply(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }
        [TestMethod]
        [DataRow(2, 0)]
        [DataRow(2, 1)]
        [DataRow(2, 2)]
        public void potenzaTest(int b, int e)
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Potenza(b, e);
            var ris = (int)Math.Pow(b, e);

            //Console.WriteLine("Risultato test = " + ris.ToString());
            // Assert
            Assert.AreEqual(ris, actual);
        }


        [TestMethod]
        public void DivideTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 1);

            // Assert
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideByZeroTest()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var actual = calculator.Divide(1, 0);

            // Assert
            Assert.IsNull(actual);
        }


    }
}