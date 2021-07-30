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
            var newStr = s;
            var charsToRemove = new string[] {"@", ".", ",", " ", ":", ";", "'"};
            foreach (var ch in charsToRemove)
            {
                newStr = s.Replace(ch, string.Empty);
            }
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
