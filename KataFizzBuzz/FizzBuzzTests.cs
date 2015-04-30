using NUnit.Framework;

namespace KataFizzBuzz
{
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(4, "4")]
        [TestCase(7, "7")]
        public void Should_return_the_input_number_when_this_number_is_not_divisible_by_3_and_not_divisible_by_5(int input, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz.Generate(input));
        }

        [TestCase(3, "Fizz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(12, "Fizz")]
        public void Should_return_Fizz_when_the_input_number_is_divible_by_3(int input, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz.Generate(input));
        }

        [TestCase(5, "Buzz")]
        [TestCase(10, "Buzz")]
        [TestCase(20, "Buzz")]
        [TestCase(25, "Buzz")]
        public void Should_return_Buzz_when_the_input_number_is_divible_by_5(int input, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz.Generate(input));
        }

        [TestCase(15, "FizzBuzz")]
        public void Should_return_FizzBuzz_when_the_input_number_is_divible_by_3_and_by_5(int input, string expected)
        {
            Assert.AreEqual(expected, FizzBuzz.Generate(input));
        }

    }
}
