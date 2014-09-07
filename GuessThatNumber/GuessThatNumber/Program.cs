using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThatNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time to guess a number from 1-100.");

            //Generates a random number from 1-100
            while (true)
            {   // Assignments
                int randomNumber = GenerateNumber(1, 101);
                int counter = 1;
                while (true)
                {   //Writes what the parameters/instructions are
                    Console.Write("Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());

                    // If input is 0, then the console application will close
                    if (input == 0)
                        // Allows the "press any key to close the console window
                        return;
                        // Random number < text
                    else if (input < randomNumber)
                    {
                        // Writes to the console that the guess is too low: Try again
                        Console.WriteLine("Too low, try again.");
                        ++counter;
                        continue;
                    }
                        //Random number > text
                    else if (input > randomNumber)
                    {
                        Console.WriteLine("Too high, try again.");
                        ++counter;
                        continue;
                    }
                    else
                    {   //If guess is correct, then everything is fine.
                        Console.WriteLine("You guess it! The number was {0}!", randomNumber);
                        if (counter == 1)
                            //Guessing it right away will result in Bonus points
                            Console.WriteLine("And you guessed it right away! Bonus points!");
                        else
                            //Tells you the number of tries to guess correctly
                            Console.WriteLine("It took you {0} {1}.", counter, counter == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
        } // Random number generator with the parameters in place from 1-100(101 of course)
        static int GenerateNumber(int min, int max)
        {
            // This keeps everything random instead of keeping the same "random" number
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
