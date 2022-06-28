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

            //Create a random
            //Create a list of string
            //Acces the string from the list
            var random = new Random();
            int limitAttempts = 6;
            var listWords = new List<string> { "computer", "programming", "animals", "fruits", "vegetables", "cars" };
            int index = random.Next(listWords.Count);
            string randomWord = listWords[index];
            char[] guess = new char[randomWord.Length];
            Console.Write("Please enter your guess:  ");

            for (int i = 0; i < randomWord.Length; i++)
                guess[i] = '_';
            {
                while (true)
                {
                    char playerGuess = char.Parse(Console.ReadLine());
                    for (int j = 0; j < randomWord.Length; j++)
                    {
                        if (playerGuess == randomWord[j])
                            guess[j] = playerGuess;
                    }
                    Console.WriteLine($"You have {limitAttempts} left");
                    limitAttempts--;
                    Console.WriteLine(guess);
                    if (limitAttempts == 0)
                    {
                        break;
                    }
                }
            }
                

           

        }
    }
}