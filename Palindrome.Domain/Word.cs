using System;

namespace Palindrome.Domain
{
    public class Word
    {
      public static bool TestPalindrome(string input)
      {
        int midpoint = input.Length/2;
        int end = input.Length - 1;
        int start = 0;

        while(start <= midpoint)
        {
          if(input[start] != input[end] )
          {
            return false;
          }
          start +=1;
          end -=1;
        }
        
        return true;
      }
    }
}
