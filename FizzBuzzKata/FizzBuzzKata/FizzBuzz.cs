using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    public class FizzBuzz
    {

        public string GetFizzBuzz(int number)
        {
            if (IsEvenlyDivisbleByThree(number) && IsEvenlyDivisibleByFive(number))
                return "FizzBuzz";

            if (IsEvenlyDivisbleByThree(number))
                return "Fizz";

            if (IsEvenlyDivisibleByFive(number))
                return "Buzz";

            return number.ToString();
        }


        public bool IsEvenlyDivisbleByThree(int number)
        {
            return number % 3 == 0;
        }

        public bool IsEvenlyDivisibleByFive(int number)
        {
            return number % 5 == 0;
        }


    }
}
