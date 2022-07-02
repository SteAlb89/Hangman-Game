using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a random string 
            Random random = new Random();
           
            //Create a list of words
            string[] listWords = { "weather", "sport", "vacation", "money", "fitness" };
            var randomWords = random.Next(0, listWords.Length);
            string hideWord = listWords[randomWords];
            char[] guess = new char[hideWord.Length];

            //Giving more information about the word which should be guessed
            Console.WriteLine($"Hint: The word is format from {hideWord.Length} letters");

            //Ask the user to input a char
            Console.WriteLine("Please enter a letter: ");

            //Create a for loop which hide the length of the word with * 
            for ( int i = 0; i < hideWord.Length; i++)
                guess[i] = '*';
            //Create a while loop which is looping untill the the user input match the word
            bool correctLetter = true;
            while (correctLetter)
            {
                char inputLetter = char.Parse(Console.ReadLine());

                foreach(char letters in hideWord)
                {
                    if(hideWord.Contains(letters))
                        inputLetter = letters;
                }
                Console.WriteLine(guess);
                Console.WriteLine(hideWord);
            }
            //Check if the user input a char and not a other data types
            //Make a function which check if the char match to your randomWord
            //Create a variable which count the lives left if the user input doesn't match to randomWord




        }
    }
}