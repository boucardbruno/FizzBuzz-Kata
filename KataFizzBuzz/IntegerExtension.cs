namespace KataFizzBuzz
{
    public static class IntegerExtension
    {
        public static bool IsDivisbleBy(this int number, int modulo)
        {
            return number%modulo == 0;
        }
    }
}