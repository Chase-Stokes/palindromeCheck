using System;
using System.Collections.Generic;

namespace Palindrome
{
  public class PalindromeChecker
  {
    public bool PalindromeBool1(string word)
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
    public bool PalindromeBool2(string word)
    {
      char[] array1 = word.ToCharArray();
      char[] array2 = word.ToCharArray();
      bool doesMatch = true;
      int count = 0;
      for (int i = array2.Length -1; i >= 0; i--) {
        if (array1[count] != array2[i]) {
          doesMatch = false;
          break;
        }
        count++;
      }
      return doesMatch;
    }
    public bool PalindromeBool3(string Input) 
    { 
      // Converting string to character array
      char[] charArray = Input.ToCharArray(); 
      // Declaring an empty string
      string reversedString = String.Empty; 
      // Iterating the each character from right to left
      for(int i = charArray.Length - 1; i > -1; i--) 
      { 
          // Append each character to the reversedstring.
          reversedString += charArray[i]; 
      }
      // Return the reversed string.
      return (Input == reversedString);
    } 
  }
}

//Console.WriteLine("   {0}", String.Join(" ", primes));
      // take input and split it into an array
      // make a new array thats the original array reversed
      // compare the two arrays
