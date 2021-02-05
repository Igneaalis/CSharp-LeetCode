using System;
using System.Text;

namespace Leetcode
{
    
    class Program
    {

        #region Leetcode

        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                if (s.Length < 2)
                {
                    return s.Length;
                }

                var result = new StringBuilder();
                int maxLength = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    if (result.ToString().Contains(s[i]))
                    {
                        result.Clear();
                    }
                    result.Append(s[i]);
                    maxLength = result.Length > maxLength ? result.Length : maxLength;
                }

                if (maxLength == s.Length)
                {
                    return maxLength;
                }

                string curSubstring;
                for (int i = s.Length; i > 0 && maxLength < s.Length - 1; i--)
                {
                    int prevLength = maxLength;
                    for (int j = 0; j < s.Length - maxLength; j++)
                    {
                        bool doBreak = false;
                        curSubstring = s.Substring(j, maxLength + 1);
                        for (int k = 1; k < curSubstring.Length; k++)
                        {
                            if (!curSubstring.Substring(0, k).Contains(curSubstring[k]))
                            {
                                if (maxLength < k + 1)
                                {
                                    if (++maxLength == curSubstring.Length)
                                    {
                                        doBreak = true;
                                    }
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (doBreak)
                        {
                            break;
                        }
                    }
                    if (prevLength == maxLength)
                    {
                        return maxLength;
                    }
                }
                return maxLength;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            Solution s = new();
            var result = s.LengthOfLongestSubstring("dvdfddvssss");
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
