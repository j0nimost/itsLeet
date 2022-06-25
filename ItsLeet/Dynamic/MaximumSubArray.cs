using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Dynamic
{
    public class MaximumSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int max_pos = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                max_pos = max_pos + nums[i];

                if (max < max_pos)
                    max = max_pos;

                if (max_pos < 0)
                    max_pos = 0;
            }
            return max;
        }

    }
}
