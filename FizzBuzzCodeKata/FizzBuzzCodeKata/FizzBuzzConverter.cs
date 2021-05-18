using System.Collections.Generic;

namespace FizzBuzzCodeKata
{
    public class FizzBuzzConverter
    {
        public string[] Convert(int[] numbers)
        {
            var result = new List<string>();

            foreach (var number in numbers)
            {
                if(number % 3 == 0)
                {
                    result.Add("Fizz");

                    continue;
                }

                if (number % 5 == 0)
                {
                    result.Add("Buzz");

                    continue;
                }

                result.Add(number.ToString());
            }

            return result.ToArray();
        }
    }
}
