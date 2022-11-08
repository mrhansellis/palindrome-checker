using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindromes.Models;

namespace Palindromes.Tests
{
  [TestClass]
  public class WordCheckerTests
  {
    [TestMethod]
    public void WordCheck_IsPalindrome_True()
    {
    WordChecker TestWordChecker = new WordChecker();
    Assert.AreEqual(true, TestWordChecker.WordCheck("radar"));
    }
    [TestMethod]
    public void WordCheck_IsPalindrome_False()
    {
    WordChecker TestWordChecker = new WordChecker();
    Assert.AreEqual(false,TestWordChecker.WordCheck("hans")); 
    }
  }
}