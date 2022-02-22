using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool PalindromeBool(string word)
    {
      char[] newWord = word.ToCharArray();
      Array.Reverse(newWord);
      string joinedWord = new string(newWord);
      if (word == joinedWord)
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
//Console.WriteLine("   {0}", String.Join(" ", primes));
      // take input and split it into an array
      // make a new array thats the original array reversed
      // compare the two arrays
