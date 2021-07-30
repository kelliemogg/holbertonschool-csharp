using System;
using System.Collections.Generic;
using System.Linq;

namespace Text
{
    /// <summary> class Str </summary>
    public class Str
    {
        /// <summary> returns indx of second unique char </summary>
        public static int UniqueChar(string s)
        {
            char first = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if (first != s[i] && s[i] != s[i + 1])
                {
                    return (i);
                }
            }
            return -1;
        }
    }
}
