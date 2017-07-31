using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzKata;
using NUnit.Framework;

namespace FizzBuzzKataTests
{
    [TestFixture]
    public class FizzBuzzTest
    {   
        private FizzBuzz fizzBuzz;

        private const string Fizz = "Fizz";
        private const string Buzz = "Buzz";

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void InputOfOneReturns1()
        {
            var result = fizzBuzz.GetFizzBuzz(1);
            Assert.AreEqual("1", result);
        }

        [Test]
        public void InputOfTwoReturns2()
        {
            var result = fizzBuzz.GetFizzBuzz(2);
            Assert.AreEqual("2", result);
        }

        [Test]
        public void InputOfThreeReturnsFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(3);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void InputOfFiveReturnsBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(5);
            Assert.AreEqual("Buzz",result);
        }

        [Test]
        public void InputOfSixReturnsFizz()
        {
            var result = fizzBuzz.GetFizzBuzz(6);
            Assert.AreEqual("Fizz", result);
        }

        [Test]
        public void InputOfTenReturnsBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(10);
            Assert.AreEqual("Buzz", result);
        }

        [Test]
        public void InputOfFifteenReturnsFizzBuzz()
        {
            var result = fizzBuzz.GetFizzBuzz(15);
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}
