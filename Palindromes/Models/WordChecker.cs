using System;

namespace Palindromes.Models{

  public class WordChecker
  {
    public bool WordCheck(string userInput)
    {
      char[] userInputArray = userInput.ToCharArray();
      Array.Reverse(userInputArray);
      string compareString = String.Join("" , userInputArray);
      if (compareString == userInput)
      {
      return true;
      }
      else
      {
      return false;
      }
    }
  }
}