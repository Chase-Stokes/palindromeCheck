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
      Assert.AreEqual(false, testPalindrome.PalindromeBool1("cat"));
    }
    [TestMethod]
    public void PalindromeChecker_IsPalindrome_True()
    {
      Assert.AreEqual(true, testPalindrome.PalindromeBool1("catac"));
    }
    [TestMethod]
    public void PalindromeChecker_NotPalindrome2_False()
    {
      Assert.AreEqual(false, testPalindrome.PalindromeBool2("cat"));
    }
    [TestMethod]
    public void PalindromeChecker_IsPalindrome2_True()
    {
      Assert.AreEqual(true, testPalindrome.PalindromeBool2("catac"));
    }
    [TestMethod]
    public void PalindromeChecker_IsPalindrome3_True()
    {
      Assert.AreEqual(true, testPalindrome.PalindromeBool3("catac"));
    }
  }
}