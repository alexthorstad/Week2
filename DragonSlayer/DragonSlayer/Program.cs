using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlayer
{
    class Program
    {
        static void Main(string[] args)
        {


            // Player & Dragon health
            int pHealth = 100;
            int dHealth = 200;


            // Random number assignment
            Random random = new Random();

            

            // User Greeting
            Console.WriteLine("Welcome to the game!  Prepare to slayeth the Dragon!");
            

            // Asking for the username/greeting by name
            string userName;
            Console.WriteLine("Enter your name: ");
            userName = Console.ReadLine();


            // Asks the player if they are ready
            string start;
            Console.WriteLine(userName + "are you ready to begin your Epic Quest?!");
            Console.WriteLine("Hit 'Y' for yes and 'N' for no");
            start = Console.ReadLine();


            // Starting the game - option 'Yes'
            if (start == "y")
            {
                Console.WriteLine("Prepare yourself!");
            }
            

            //Starting the game - option 'No'
            else if (start == "n")
            {
                Console.WriteLine("Who wouldn't want to slay a dragon?  You yella belly pansy!  We don't tolerate running away round these parts!");
                Console.WriteLine("You've lost 10hp for running");
                
            }


            //Player weapon/heal options
            int attack1 = 1;
            int attack2 = 2;
            int attack3 = 3;


            // Player attack names
            // 1 = Sword, 2 = Fireball, 3 = Heal
            Console.WriteLine("1 Psi Storm");
            Console.WriteLine("2 Zergling Attack!");
            Console.WriteLine("3 Queen Transfusion!");
            Console.ReadLine();


            // Dragon attack names
            // 0 = Colossal Beam Breath
            int attack0 = 0;


            


                // Player attack1
                // This attack deals 20-35 damage, but only hits 70% of the time
                int attack1chance = random.Next(1, 101);

                if (attack1chance <= 30)
                {
                    Console.WriteLine("Build moor High Templar!");
                }
                else
                {

                    int randomNumber = random.Next(20, 36);
                    dHealth -= attack1;
                }


                // Player attack2
                // This attack deals 10-15 damage and hits all the time, every time, 100% of the time guaranteed.
                if (attack2 == 2)
                {
                    int randomNumber = random.Next(10, 16);
                    dHealth -= attack2;
                }


                // Player attack3
                // This heals the user for 10-20 Health 100% of the time every damn time
                if (attack3 == 3)
                {
                    int randomNumber = random.Next(10, 21);
                    pHealth += pHealth;
                }

                // Dragon attack0
                // Dragon will hit 80% of the time for 5-15 damage
                int attack0chance = random.Next(1, 101);


                if (attack0chance <= 20)
                {
                    Console.WriteLine("I have missed you for now...  You Zerg, Protoss hybrid, but I will have my reveeeeeeeeeeeenge!");
                }


                else
                {
                    int randomNumber = random.Next(5, 16);
                    Console.WriteLine("Your Zerglings are no match for me!");
                    pHealth -= attack0;
                }


                if (pHealth <= 0)
                {
                    Console.WriteLine("Pitiful Terran, should have Widow Mined my base!");
                }

                else if (dHealth <= 0)
                {
                    Console.WriteLine("Why the hell was a Dragon in SC2:HOS?");
                }

                Console.ReadLine();
            {
                //Player and Dragon Health
                Console.WriteLine("Player Health" + pHealth);
                Console.WriteLine("Dragon Health" + dHealth);
            }
            while (Console.ReadLine().ToLower() != "exit");



        } 
    }
}
