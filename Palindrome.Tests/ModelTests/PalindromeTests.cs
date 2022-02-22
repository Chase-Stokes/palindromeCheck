using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace Palindrome.TestTools
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void PalindromeChecker_Example_Result()
    {
      PalindromeChecker testPalindrome = new PalindromeChecker();
      Assert.AreEqual(false, testPalindrome.PalindromeBool("cat"));
    }
  }
}