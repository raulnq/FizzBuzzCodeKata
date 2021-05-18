using FizzBuzzCodeKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzCodeKataTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void it_is_the_same_number_when_it_is_not_multiple_of_five_or_three()
        {
            var converter = new FizzBuzzConverter();

            var numbers = new int[] { 1 };

            var result = converter.Convert(numbers);

            Assert.AreEqual(1, result.Length);

            Assert.AreEqual("1", result[0]);
        }

        [TestMethod]
        public void it_is_fizz_when_the_number_is_multiple_of_three()
        {
            var converter = new FizzBuzzConverter();

            var numbers = new int[] { 3 };

            var result = converter.Convert(numbers);

            Assert.AreEqual(1, result.Length);

            Assert.AreEqual("Fizz", result[0]);
        }

        [TestMethod]
        public void it_is_buzz_when_the_number_is_multiple_of_five()
        {
            var converter = new FizzBuzzConverter();

            var numbers = new int[] { 5 };

            var result = converter.Convert(numbers);

            Assert.AreEqual(1, result.Length);

            Assert.AreEqual("Buzz", result[0]);
        }

        [TestMethod]
        public void it_is_fizzbuzz_when_the_number_is_multiple_of_five_and_three()
        {
            var converter = new FizzBuzzConverter();

            var numbers = new int[] { 15 };

            var result = converter.Convert(numbers);

            Assert.AreEqual(1, result.Length);

            Assert.AreEqual("FizzBuzz", result[0]);
        }
    }
}
