using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Sorting
{
    public class GroupAnagramSolution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, IList<string>> stringDict = new Dictionary<string, IList<string>>();

            // O(n)
            for (int i = 0; i < strs.Length; i++)
            {
                char[] anagramsArr = strs[i].ToCharArray();
                /// O(nLogn);
                Sort(anagramsArr, 0, strs[i].Length-1);
                string uniqueAnagram = new string(anagramsArr); // BAD
                if (!stringDict.ContainsKey(uniqueAnagram))
                    stringDict.Add(uniqueAnagram, new List<string>() { strs[i]});
                else
                    stringDict[uniqueAnagram].Add(strs[i]); 
            }

            // O(n)
            return stringDict.Values.ToList();
        }


        private void Sort(char[] arr, int l, int h)
        {
            if(l < h)
            {
                int m = l + (h - l)/2;
                Sort(arr, l, m);
                Sort(arr, m+1, h);

                Merge(arr, l, m, h);
            }
        }

        private void Merge(char[] arr, int l, int m, int h)
        {
            int n1 = m - l+1;
            int n2 = h-m;

            char[] lArr = new char[n1];
            char[] rArr = new char[n2];


            // COPY VALUES
            System.Array.Copy(arr, l, lArr, 0, n1);
            System.Array.Copy(arr, m+1, rArr, 0, n2);

            int i=0,j=0;
            int k = l;

            while(i<n1 && j< n2)
            {
                if (lArr[i] <= rArr[j])
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

            // add what's remaining

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
