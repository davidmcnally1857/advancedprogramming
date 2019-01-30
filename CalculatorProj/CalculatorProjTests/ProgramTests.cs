using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj.Tests
{

    /* This is a test class that tests the
     * operations and the inputs of the 
     * Calculator program 
     */ 

    [TestClass()]
    public class ProgramTests {

        public double x;
        public double y;

        [TestMethod()]
        public void Adding3plus3ShouldGive6() {

            Calculator calculator = new Calculator();
             x = 3;
             y = 3;
            Assert.AreEqual(6, calculator.Add(x, y));
        }
        [TestMethod()]
        public void Adding5plusMinus6ShouldGiveMinus1()
        {

            Calculator calculator = new Calculator();
            x = 5;
            y = -6;
            Assert.AreEqual(-1, calculator.Add(x, y));
        }

        [TestMethod()]
        public void Subtract18by3ShouldGive15() {
            Calculator calculator = new Calculator();
             x = 18;
             y = 3;
            Assert.AreEqual(15, calculator.Subtract(x, y));
        }
        [TestMethod()]
        public void Subtract10byMinus10ShouldGive20()
        {
            Calculator calculator = new Calculator();
            x = 10;
            y = -10;
            Assert.AreEqual(20, calculator.Subtract(x, y));
        }

        [TestMethod()]
        public void Multplying7by8ShouldGive56() {
            Calculator calculator = new Calculator();
             x = 7;
             y = 8;
            Assert.AreEqual(56, calculator.Multiply(x, y));
        }

        [TestMethod()]
        public void Multplying7byMinus8ShouldGiveMinus56()
        {
            Calculator calculator = new Calculator();
            x = 7;
            y = -8;
            Assert.AreEqual(-56, calculator.Multiply(x, y));
        }

        [TestMethod()]
        public void Divide120by10SHouldGive12() {
            Calculator calculator = new Calculator();
             x = 120;
             y = 10;
            Assert.AreEqual(12, calculator.Divide(x, y));
         }

        [TestMethod()]
        public void Divide5byMinus2()
        {
            Calculator calculator = new Calculator();
            x = 5;
            y = -2;
            Assert.AreEqual(-2.5, calculator.Divide(x, y));
        }

        [TestMethod()]
        public void DivideBYZeroShouldGiveAnError() {
            Calculator calculator = new Calculator();
             x = 12;
             y = 0;
            Assert.AreEqual(-1, calculator.Divide(x, y));
        }

        [TestMethod()]
        public void Modulo50by3ShouldGive2() {
            Calculator calculator = new Calculator();
             x = 50;
             y = 3;
            Assert.AreEqual(2, calculator.Modulo(x, y));
        }

       


        [TestMethod()]
        public void SquaredBy10ShoulsGive100()
        {
            Calculator calculator = new Calculator();
             x = 10;
            Assert.AreEqual(100, calculator.Squared(x));
        }

        [TestMethod()]
        public void SquaredByMinus10ShoulsGiveMinus100()
        {
            Calculator calculator = new Calculator();
            x = -10;
            Assert.AreEqual(100, calculator.Squared(x));
        }

        [TestMethod()]
        public void CubedBy10ShoulsGive1000()
        {
            Calculator calculator = new Calculator();
             x = 10;
            Assert.AreEqual(1000, calculator.Cubed(x));
        }

        [TestMethod()]
        public void CubedByMinus10ShoulsGiveMinus1000()
        {
            Calculator calculator = new Calculator();
            x = -10;
            Assert.AreEqual(-1000, calculator.Cubed(x));
        }

        [TestMethod()]
        public void SquareRootOf25ShouldGive5()
        {
            Calculator calculator = new Calculator();
             x = 25;
            Assert.AreEqual(5, calculator.SquareRoot(x));
        }

     
        [TestMethod()]
        public void CalculateSin()
        {
            Calculator calculator = new Calculator();
            x = 30;
            Assert.AreEqual(-0.98803162409, calculator.Sin(x));

        }

        [TestMethod()]
        public void CalculateSinOfNegativeNumber()
        {
            Calculator calculator = new Calculator();
            x = -40;
            Assert.AreEqual(-0.74511316048, calculator.Sin(x));

        }

      

        [TestMethod()]
        public void CalculateCos()
        {
            Calculator calculator = new Calculator();
            x = 40;
            Assert.AreEqual(-0.66693806165, calculator.Cos(x));
            

        }
        [TestMethod()]
        public void CalculateCosOfNegativeNumber()
        {
            Calculator calculator = new Calculator();
            x = -25;
            Assert.AreEqual(0.99120281186, calculator.Cos(x));


        }



        [TestMethod()]
        public void CalculateTan()
        {
            Calculator calculator = new Calculator();
            x = 20;
            Assert.AreEqual(2.23716094422, calculator.Tan(x));

        }

        [TestMethod()]
        public void CalculateTanOfNegativeNumber()
        {
            Calculator calculator = new Calculator();
            x = -30;
            Assert.AreEqual(6.40533119665, calculator.Tan(x));

        }




    }
}