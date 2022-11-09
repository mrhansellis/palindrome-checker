using System;

namespace Palindromes
{

  public class WordChecker
  {
    public bool WordCheck(string userInput)
    {
      
      char[] userInputArray = userInput.ToCharArray();
      int length = userInputArray.Length;
      for (int i = 0; i < length; i++)
      {
        if (userInputArray[i] != userInputArray[length - 1 - i])
          return false;
      }
      return true;
      }
      
    public bool WordCheck(int Input)
    {
      string userInput = Input.ToString();
      char[] userInputArray = userInput.ToCharArray();
      int length = userInputArray.Length;
      for (int i = 0; i < length; i++)
      {
        if (userInputArray[i] != userInputArray[length - 1 - i])
            return false;
      }
      return true;
      }
    } 
  }





      // Array.Reverse(userInputArray);
      // string compareString = String.Join("" , userInputArray);
      // if (compareString == userInput)
      // {
      // return true;
      // }
      // else
      // {
      // return false;