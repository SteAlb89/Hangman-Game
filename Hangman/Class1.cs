using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class Class1
    {
        class Words
        {
            public static bool WordCompare(char[] inputChar, char[] storredLetter)
            {
               

                if (inputChar.Length != storredLetter.Length)

                    for (int i = 0; i < inputChar.Length; ++i)
                    {
                        if (inputChar[i] == storredLetter[i])
                        {
                            storredLetter[i] = inputChar[i];
                            Console.WriteLine($"Letters already in {inputChar} ");

                        }
                    }
                return true;
            }
        }
    }
}
