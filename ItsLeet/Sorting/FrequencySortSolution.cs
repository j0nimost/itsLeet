using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Sorting
{
    public class FrequencySortSolution
    {
        public string FrequencySort(string s)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>(); // should be <= 62
            // count occurence
            //... O(n)
            foreach (char c in s)
            {
                if (!counts.ContainsKey(c))
                    counts[c] = 1;
                else
                    counts[c]++;
            }

            // get the values in an array

            int[] arr = counts.Values.ToArray();

            // sort array
            // since the array can be only 62 in length in worst case scenario
            // I use O(n*n)
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] > arr[i])
                    {
                        int swap = arr[j];
                        arr[j] = arr[i];
                        arr[i] = swap;
                    }
                }
            }


            // iterate through dict
            // get the chars values matching arr
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (var kv in counts)
                {
                    if(kv.Value == arr[i])
                    {
                        int v = 0;
                        while(v < arr[i])
                        {
                            stringBuilder.Append(kv.Key);
                            v++;
                        }

                        counts.Remove(kv.Key); // improve the efficiency of each iteration
                    }
                }
            }


            return stringBuilder.ToString();
        }
    }
}
