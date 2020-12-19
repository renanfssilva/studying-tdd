using FizzBuzz.Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private readonly FizzBuzzService _fizzBuzz;
        
        public FizzBuzzTests()
        {
            _fizzBuzz = new FizzBuzzService();
        }

        [TestMethod]
        public void ShouldPrintNumber()
        {
            Assert.AreEqual("2", _fizzBuzz.Print(2));
        }
        
        [TestMethod]
        public void ShouldPrintFizz()
        {
            Assert.AreEqual("Fizz", _fizzBuzz.Print(3));
        }

        [TestMethod]
        public void ShouldPrintBuzz()
        {
            Assert.AreEqual("Buzz", _fizzBuzz.Print(5));
            Assert.AreEqual("Buzz", _fizzBuzz.Print(10));
        }
        
        [TestMethod]
        public void ShouldPrintFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(30));
        }
    }
}
