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
            Dictionary<char,int> unFind = new Dictionary<char,int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!unFind.ContainsKey(s[i]))
                    unFind.Add(s[i], 1);
                else
                    unFind[s[i]] += 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (unFind[s[i]] == 1)
                    return i;
            }
            return -1;
        }
    }
}
