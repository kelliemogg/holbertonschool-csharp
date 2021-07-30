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
            char [] og = newStr.ToCharArray();
            char [] compare = new char[newStr.Length];
            for (int i = og.Length - 1; i >= 0; i--)
            {
                og[i] = compare[i];
            }
            for (int i = 0; i < newStr.Length; i++)
            {
                if (og[i] != compare[i])
                    return false;
            }
            return true;
        }
    }
}
