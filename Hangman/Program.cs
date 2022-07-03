﻿using System;
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
            var randomIndex = random.Next(0, listWords.Length);
            string hiddenWord = listWords[randomIndex];
            char[] displayWord = new char[hiddenWord.Length];


            //Giving more information about the word which should be guessed
            Console.WriteLine($"Hint: The word is format from {hiddenWord.Length} letters ");

            //Ask the user to input a char
            Console.WriteLine("Please enter a letter: ");

            //Create a for loop which hide the length of the word with * 
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                displayWord[i] = '*';

            }
            //Create a while loop which is looping untill the the user input match the word
            bool gameIsRunning = true;
            int lives = 8;

            while (gameIsRunning)
            {               
                char inputChar;
                bool isLetter = char.TryParse(Console.ReadLine(), out inputChar);

                //Check if the user input a char and not a other data types
                if (!isLetter)
                {
                    Console.WriteLine("Please enter just a charachter or a letter like a, b, c");
                    continue;
                }
                //Create a for loop which show if the guessed a letter
                for (int j = 0; j < hiddenWord.Length; j++)
                {
                    if (inputChar == hiddenWord[j])
                    {
                        displayWord[j] = inputChar;
                    }                    
                }
                //Create an if statements to show to the user which guessed letter is correct and which not !
                if (hiddenWord.Contains(inputChar))
                {
                    Console.WriteLine($"You guessed: {inputChar} , and it is correct !");
                }
                else if (!hiddenWord.Contains(inputChar))
                {
                    Console.WriteLine($"You guessed: {inputChar}, and it is incorrect");
                    lives--;
                }
                Console.WriteLine($"You still have: {lives} left  ");

                Console.WriteLine(displayWord);

                //Create a variable which count the lives left if the user input doesn't match to randomWord
                if (lives == 0)
                {
                    Console.WriteLine($"Sorry , but you are out of lives. The word was: {hiddenWord}");
                    gameIsRunning = false;
                }
                
            }
        }
    }
}