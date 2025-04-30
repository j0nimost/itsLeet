namespace ItsLeet.ArrayQuestions;

public class CountSubArrayClass
{
    public long CountSubarrays(int[] nums, int k) {
        // find maximum value in nums
        var max = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, nums[i]);
        }

        long count = 0;
        var l = 0;
        var c = 0;
        for (var r = 0; r < nums.Length; r++)
        {
            if (nums[r] == max)
                c++;
            while (c >= k)
            {
                count += nums.Length - r;

                if (nums[l] == max)
                    c--;
                l++;
            }
        }
        return count;
    }
}