using System;
using System.Threading;
using System.Collections.Generic;
using Palindromes;

namespace Palindromes
{

    public class Program
    {
        public static void Main()
        {
          Console.WriteLine("Input number or word to check if it's a Palindrome");
          string userInput = Console.ReadLine();
          Thread.Sleep(1000);
          WordChecker word1 = new WordChecker();
          if (word1.WordCheck(userInput) == true) 
          {
            Console.WriteLine("That's a palindrome, baby!");
          }
          else
          {
            Console.WriteLine("That's not a palindrome...");
          }
          Main();

        }
    }
}