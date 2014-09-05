using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        private static string returnString;
        static void Main(string[] args)
        {
            string name;
            // Ask user to enter their name
            Console.Write("Enter your name: ");
            // Console reads the name and prints it out
            name = Console.ReadLine();
            // Display user greeting
            Console.WriteLine("Welcome to the Game!");
            // Game instructions
            Console.WriteLine("Throughout this game you will be guessing letters of the word until you can guess the word or all of the letters.");
            Console.ReadLine();
        }
        static void hangMan(string[] word)
        {
            // Create wordBank list
            List<string> wordBank = new List<string>() { "Broncos", "Chargers", "Falcons", "Browns", "Patriots" };
            // Create random word generator
            Random randGen = new Random();

            // Declare variable to hold lives
            int lives = 7;
            // Create container for letters guessed
            string lettersGuessed = (Console.ReadLine());
            // Get random string from wordBank
            string wordtoGuess = wordBank[randGen.Next(1, wordBank.Count)];
            // User has not won yet
            bool won = false;

            // Create loop while still playing game
            while (lives > 0 || !won)
            {   
                // Display masked word, number of guesses, letters used
                Console.WriteLine(maskedWord (wordtoGuess, lettersGuessed));
                Console.WriteLine("Lives left: " + lives);
                Console.WriteLine("Letters guessed: " + lettersGuessed);
                // Get a guess from the user

                // Is guess one character
                //guess is one character, compare to letters in word to guess
                //does the letter match?
                //letter matches, reveal in masked word, subtract a life, add to letters guessed
                //letter does not match, subtract a life, add to letters guessed

                //guess is not one character, compare to word to guess
                //does the word match?
                //the word matches, display the word, congratulate the user
                //the word does not match, subtract a guess
                
            }

            // 

        }
        //create function for Display Masked Word
        static string maskedWord(string wordtoGuess, string lettersGuessed)
        {
            //get word to guess and letters guessed list

            //declare output
            returnString = "";

            int i = 0;

            while (i < wordtoGuess.Length)
            {
                //get a letter from the word
                string letter = wordtoGuess[i].ToString();
                //did the user guess the current letter in the word?
                if (lettersGuessed.Contains(letter))
                {
                    //user guessed the right letter
                    //add letter to the return string
                    returnString += letter;
                }
                else
                {
                    //letter not found
                    //add an underscore to the return string
                    returnString += "_";
                }

                
            }
                    //display return string
                    return returnString;


        }
    }
}
