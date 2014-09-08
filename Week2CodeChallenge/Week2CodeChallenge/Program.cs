using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //1

            //create a loop from 0<=20
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }

        }
        static void FizzBuzz(int number)
        {
            if (number % 5 == 0)
            {
                //# is divisible by 5
                Console.WriteLine("Fizz");
            }

            if (number % 3 == 0)
            {
                //# is divisible by 3
                Console.WriteLine("Buzz");
            }

            if (number % 5 == 0 && number % 3 == 0)
            {
                //# is divisible by 5 && 3
                Console.WriteLine("FizzBuzz");
                Console.Read();
            }
        }
        static void LetterCounter(string name)
        {
            char letter =;
            string inString =;
        }
    }
}