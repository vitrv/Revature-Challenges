using System;
using Xunit;
using Palindrome.Domain;

namespace Palindrome.Test
{
  public class UnitTest1
  {
      [Fact]
      public void Test1()
      {
        string word = "racecar";
        bool result = Word.TestPalindrome(word);
        Assert.True(result);
      }
      [Fact]
      public void Test2()
      {
        string word = "kjhgfdsdfg";
        bool result = Word.TestPalindrome(word);
        Assert.False(result);
      }
      [Fact]
      public void Test3()
      {
        string word = "abdfcba";
        bool result = Word.TestPalindrome(word);
        Assert.False(result);
      }
  }
}
