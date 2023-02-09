using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Skillfactory._16._7.Tests
{
    [TestFixture]

    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Additional(10, 20), Is.EqualTo(30));
        }

        [Test]
        public void Substraction_MustReturnCorrectValue()
        {
            var calculatorTest1 = new Calculator();
            Assert.That(calculatorTest1.Subtraction(10, 5), Is.EqualTo(5));
        }

        [Test]
        public void Multiplication_MustReturnCorrectValue()
        {
            var calculatorTest2 = new Calculator();
            Assert.That(calculatorTest2.Miltiplication(3, 5), Is.EqualTo(15));
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculatorTest3 = new Calculator();
            Assert.That(calculatorTest3.Division(20, 4), Is.EqualTo(5));
        }
    }
}