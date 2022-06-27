using System;
using System.Collections.Generic;
namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a random
            //Create a list of string
            //Acces the string from the list
           var random = new Random();
           var listWords = new List<string>{"computer", "programming", "animals", " fruits", "vegetables", "cars" };
           var index = random.Next(listWords.Count);

        }
    }
}