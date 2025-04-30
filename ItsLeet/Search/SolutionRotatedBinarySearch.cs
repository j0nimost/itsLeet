using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Search
{
    public class SolutionRotatedBinarySearch
    {
        public int Search(int[] nums, int target)
        {
            if(nums.Length == 1) return nums[0] == target ? 0 : -1;

            int mid = nums.Length / 2;

            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] > target  && nums[0] > target)
            {
                return BinarySearch(mid + 1, nums.Length - 1, target, nums);
            }
            else if (nums[mid] < target)
            {
                return BinarySearch(mid + 1, nums.Length - 1, target, nums);
            }
            else if((nums[mid] > target || nums[mid] < target) && nums[0] <= target)
            {
                return BinarySearch(0, mid - 1, target, nums);
            }
            return -1;
        }

        public int BinarySearch(int low, int high, int target, int[] nums)
        {
            int mid = (low + high)/2;

            if(low == high)
            {
                if (nums[high] == target) return high;
                return -1;
            }

            if (high < 0 || low > nums.Length-1) return -1;
            
            if(nums[mid] == target)
            {
                return mid;
            }
            else if(nums[mid] < target)
            {
                return BinarySearch(mid+1, high, target, nums);
            }
            else if(nums[mid] > target)
            {
                return BinarySearch(low, mid - 1, target, nums);
            }

            return -1;
        }
    }
}
