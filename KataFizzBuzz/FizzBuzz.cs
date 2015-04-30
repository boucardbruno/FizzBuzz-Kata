using System;
using System.Globalization;

namespace KataFizzBuzz
{
    public class FizzBuzz
    {
        public static string Generate(int number)
        {
            var result = string.Empty;

            if (number.IsDivisbleBy(3))
                result += "Fizz";

            if (number.IsDivisbleBy(5))
                result += "Buzz";

            return IsDefault(result) ? HandleDefault(number) : result;
        }

        private static string HandleDefault(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }

        private static bool IsDefault(string result)
        {
            return String.IsNullOrEmpty(result);
        }
    }
}