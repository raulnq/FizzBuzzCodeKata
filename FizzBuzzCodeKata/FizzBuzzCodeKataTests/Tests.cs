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
    }
}
