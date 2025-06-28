using NUnit.Framework;
using CalcLibrary;  

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        [TestCase(2, 3, 5)]
        [TestCase(10, 15, 25)]
        [TestCase(-5, 5, 0)]
        public void Add_ShouldReturnCorrectResult(int a, int b, int expected)
        {
            int result = calc.Add(a, b);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
