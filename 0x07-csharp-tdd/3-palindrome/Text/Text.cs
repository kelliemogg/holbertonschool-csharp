using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    /// <summary> class Str </summary>
    public class Str
    {
        /// <summary> palindrome check </summary>
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }
            var newStr = s; 
            newStr.Replace("@", "");
            newStr.Replace(",", "");
            newStr.Replace(".", "");
            newStr.Replace(" ", "");
            newStr.Replace(":", "");
            newStr.Replace(";", "");
            newStr.Replace("@", "'");
            newStr.Replace("@", "?");
            if (newStr.Length <= 1)
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
