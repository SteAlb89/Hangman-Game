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
            var listWords = new List<string> { "computer", "programming", "animals", "fruits", "vegetables", "cars" };
            int index = random.Next(listWords.Count);
            string randomWord = listWords[index];
            char[] guess = new char[randomWord.Length];
            Console.WriteLine($"Hint: The word contain : {randomWord.Length} letters");
            Console.Write("Please enter your guess:  ");
            int limitAttempts = randomWord.Length;

            for (int i = 0; i < randomWord.Length; i++)
                guess[i] = '*';
            {
                while (true)
                {
                    char playerGuess = Convert.ToChar(Console.ReadLine()[0]);

                    for (int j = 0; j < randomWord.Length; j++)
                    {
                        if (playerGuess == randomWord[j])
                            guess[j] = playerGuess;
                    }
                    Console.WriteLine($"You have:  {limitAttempts} left");
                    Console.WriteLine(guess);
                    if (limitAttempts == 0)
                    {
                        break;
                    }
                    limitAttempts--;
                }
            }
        }
    }
}