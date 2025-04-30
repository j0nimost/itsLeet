using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Search
{
    public class SolutionBinarySearch
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 1)
                return nums[0] < target ? nums.Length : 0;

            int mid = nums.Length / 2;

            if (nums[mid] == target)
                return mid;
            else if (nums[mid] < target)
            {
                return BinarySearch(mid+1, nums.Length - 1, target, nums);
            }
            else if (nums[mid] > target)
            {
                return BinarySearch(0, mid-1, target, nums);

            }

            return mid;
        }

        public int BinarySearch(int lower, int high, int target, int[] nums)
        {
            int mid =  (high + lower) / 2;

            if (high < 0) return high + 1;
            if(high < lower) return nums.Length;
            if(high == lower)
            {
                if (nums[high] == target) return high;
                if(nums[high] < target) return high + 1;
                return high;
            }

            if (nums[mid] == target)
            {
                return mid;
            }
            else if (nums[mid] < target)
            {
                return BinarySearch(mid + 1, high, target, nums);
            }
            else if (nums[mid] > target)
            {
                return BinarySearch(0, mid - 1, target, nums);
            }

            return mid;
        }
    }
}
