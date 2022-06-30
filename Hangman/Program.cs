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
            
            string[] listWords = { "computer", "programming", "animals", "fruits", "vegetables", "cars" };
            int correctLetter = 0;

            Random random = new Random();
            int randomWord = random.Next(0, listWords.Length);

            string word = listWords[randomWord];

            int limitAttempts = 8;

            bool guessedLetter = false;

            string guess;

            
            while (limitAttempts >= 1 || !(correctLetter == word.Length))
            {
                Console.WriteLine("Please enter a letter: ");
                Console.WriteLine($"The word is format from: {word.Length} letters");

                guess = Console.ReadLine();
                if(word.Contains(guess))
                {                   
                    if (guess == word)
                    {
                        guessedLetter = true;
                        break;
                    }else if(correctLetter == word.Length)
                    {
                        guessedLetter = true;
                        break;
                    }
                    else
                    {
                        correctLetter++;
                        Console.WriteLine($"Correct letters :{correctLetter} ");
                    }
                }
                else
                {
                    limitAttempts--;
                    if (limitAttempts == 7)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if (limitAttempts == 6)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if(limitAttempts == 5)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if(limitAttempts == 4)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if(limitAttempts == 3)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if(limitAttempts == 2)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if(limitAttempts == 1)
                    {
                        Console.WriteLine($"You still have: {limitAttempts} chance");
                    }
                    else if (limitAttempts == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Wrong guess");
                    Console.WriteLine($"Right: {correctLetter}");
                    guess = "";
                    
                }
                

            }
            if (limitAttempts >= 1 || correctLetter == word.Length || guessedLetter)
            {
                Console.WriteLine("Congratulation ! You guessed the word");
                Console.WriteLine($"The word was : {word}");
            }
            else
            {
                Console.WriteLine($"You lose ! The word was {word}");
            }
            Console.ReadKey();
        }
    }
}