using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disemvoweler
{
    class Program
    {
        static void Main(string[] args)
        {
            Disemvoweler("Nickleback is my favorite band. Their songwriting can't be beat!");
            Disemvoweler("How many bears could bear grylls grill if bear grylls could grill bears?");
            Disemvoweler("I'm a code ninja, bab. I make the functions and I make the calls");

            Console.Read();
        }

        static void Disemvoweler(string input)
        {
            // outputs the variables
            string input1 = "";

            string vowel = string.Empty;

            // loop through
            for (int i = 0; i < input.Length; i++)
            {
                // if statement that looks for vowels
                if (" aeiou".Contains(input[i]))
                {

                    input1 = input1 + input[i];
                }
                else
                {
                    vowel = vowel + input[i];
                }
            }
            Console.WriteLine("Original" + input);
            Console.WriteLine("Disemvoweled" + input1);

        }
    }
}