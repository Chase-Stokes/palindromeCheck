using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.TestTools
{
  [TestClass]
  public class ClassNameTests
  {
    PalindromeChecker testPalindrome = new PalindromeChecker();
    
    [TestMethod]
    public void PalindromeChecker_NotPalindrome_False()
    {
      Assert.AreEqual(false, testPalindrome.PalindromeBool("cat"));
    }
  }
}