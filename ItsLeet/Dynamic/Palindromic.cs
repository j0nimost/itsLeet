using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Dynamic
{
    public class Palindromic
    {
        public string LongestPalindrome(string s)
        {
            int max = 0; // length
            int lowIndex = 0;

            if (s.Length == 0 || s.Length == 1) return s;
            if(s.Length == 2 && s[0] != s[1]) return s[0].ToString();


            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if(s[i] == s[j])
                    {
                        // loop and check
                        //int mid = (j - i) / 2;
                        bool isPalindrome = true;
                        int counter = 0;
                        for (int k = i; k < j; k++)
                        {
                            if(s[k] != s[j-counter])
                            {
                                if (j - i == 2) continue;
                                isPalindrome = false;
                                break;
                            }
                            counter++;
                        }

                        if (isPalindrome && j-i+1 > max)
                        {
                            max = Math.Max(max, j-i+1);
                            lowIndex = i;
                        }

                    }
                }
            }
            if(max == 0 && s[0] == s[s.Length-1])
            {
                return s[0].ToString(); 
            }
            return s.Substring(lowIndex, max);
        }
    }
}
