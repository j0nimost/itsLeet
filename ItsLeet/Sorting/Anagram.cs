using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Sorting
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
                return false;

            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();

            // sort each
            // ... O(nLogn)
            Sort(sArr, 0, sArr.Length-1);
            Sort(tArr, 0, tArr.Length-1);

            // iterate and validate they match
            // O(n)

            for (int i = 0; i < sArr.Length; i++)
            {
                if(sArr[i] != tArr[i])
                    return false;
            }

            return true;
        }

        public void Sort(char[] arr, int l, int h)
        {
            if(l < h)
            {
                int  m = l + (h - l)/2;
                Sort(arr, l, m);
                Sort(arr, m+1, h);

                Merge(arr, l, m, h);
            }
        }

        public void Merge(char[] arr, int l, int m, int h)
        {
            int n1 = m - l + 1;
            int n2 = h - m;

            char[] lArr = new char[n1];
            char[] rArr = new char[n2];

            Array.Copy(arr, l, lArr, 0, n1);
            Array.Copy(arr, m+1, rArr, 0, n2);


            int i = 0, j=0;
            int k = l;

            while(i < n1 && j < n2)
            {
                if(lArr[i] <= rArr[j])
                {
                    arr[k] = lArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rArr[j];
                    j++;
                }
                k++;
            }


            // copy any remaining elements
            while(i < n1)
            {
                arr[k] = lArr[i];
                i++;
                k++;
            }

            while(j < n2)
            {
                arr[k] = rArr[j];
                j++;
                k++;
            }
        }
    }
}
