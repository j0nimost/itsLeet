using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Sorting
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {

            System.Array.Sort(nums);
            HashSet<string> set = new HashSet<string>();
            IList<IList<int>> listF = new List<IList<int>>();
            IList<int> minSum = new List<int>();

            int k =nums.Length-1;

            int sum = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                int j = i + 1;
                k = nums.Length - 1;
                while (j < k)
                {

                    sum = nums[i] + nums[j] + nums[k];
                    string comb = $"{nums[i]}, {nums[j]}, {nums[k]}";
                    if (sum == 0 && set.Add(comb))
                    {
                        minSum = new List<int>() { nums[i], nums[j], nums[k] };

                        listF.Add(minSum);
                        
                    }

                    else if(sum > 0)
                    {
                        k--;
                    }

                    else
                        j++;
                }
            }

            return listF; 
        }
    }
}
