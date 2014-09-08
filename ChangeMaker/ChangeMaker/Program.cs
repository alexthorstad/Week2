using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            // AMounts that we're finding it out for
            ChangeMaker(3.18);
            Console.WriteLine("\n\n");
            ChangeMaker(.99);
            Console.WriteLine("\n\n");
            ChangeMaker(12.93);
            Console.WriteLine("\n\n");
            ChangeMaker(1000.00);
            Console.WriteLine("\n\n");
            ChangeMaker(9423.74);
            Console.WriteLine("\n\n");
            Console.Read();
        }
        static void ChangeMaker(double amount)
        {
            //our remainder shall go hur
            double leftoverZa = amount;
            // variable amounts
            double hundreds = 100.00;
            double fifties = 50.00;
            double twenties = 20.00;
            double tens = 10.00;
            double fives = 5.00;
            double ones = 1.00;
            double quarters = .25;
            double dimes = .10;
            double nickels = .1;
            double pennies = .01;

            double hundoBill = 0;
            double fiddyBill = 0;
            double twentyBill = 0;
            double tenBill = 0;
            double fiveBill = 0;
            double oneBill = 0;
            double quarterChange = 0;
            double dimeChange = 0;
            double nickelChange = 0;
            double pennyChange = 0;

            // Here we shall find the correct change amount and remainder/s
            hundoBill = leftoverZa / hundreds;
            leftoverZa = leftoverZa % hundreds;

            fiddyBill = leftoverZa / fifties;
            leftoverZa = leftoverZa % fifties;

            twentyBill = leftoverZa / twenties;
            leftoverZa = leftoverZa % twenties;

            tenBill = leftoverZa / tens;
            leftoverZa = leftoverZa % tens;

            fiveBill = leftoverZa / fives;
            leftoverZa = leftoverZa % fives;

            oneBill = leftoverZa / ones;
            leftoverZa = leftoverZa % ones;

            quarterChange = leftoverZa / quarters;
            leftoverZa = leftoverZa % quarters;

            dimeChange = leftoverZa / dimes;
            leftoverZa = leftoverZa % dimes;

            nickelChange = leftoverZa / nickels;
            leftoverZa = leftoverZa % nickels;

            pennyChange = leftoverZa / pennies;
            leftoverZa = leftoverZa % pennies;

            Console.WriteLine("Amount: $" + amount);
            Console.WriteLine(Math.Floor(hundreds) + "hundred");
            Console.WriteLine(Math.Floor(fifties) + "fifty");
            Console.WriteLine(Math.Floor(twenties) + "twenty");
            Console.WriteLine(Math.Floor(tens) + "ten");
            Console.WriteLine(Math.Floor(fives) + "five");
            Console.WriteLine(Math.Floor(ones) + "one");
            Console.WriteLine(Math.Floor(quarters) + "quarter");
            Console.WriteLine(Math.Floor(dimes) + "dime");
            Console.WriteLine(Math.Floor(fives) + "five");
            Console.WriteLine(Math.Floor(pennies) + "penny");


        }
    }
}