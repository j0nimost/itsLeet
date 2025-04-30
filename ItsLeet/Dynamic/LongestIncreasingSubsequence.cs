namespace ItsLeet.Dynamic;

public class LongestIncreasingSubsequence
{
    public int LengthOfLIS(int[] nums) {
        var resultArray = new int[nums.Length];

        for (var i = 0; i < nums.Length; i++)
        {
            resultArray[i] = 1;
        }
        
        for (var i = 1; i < nums.Length; i++)
        {
            for (var j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                {
                    resultArray[i] = Math.Max(resultArray[i], resultArray[j] + 1);
                } 
            }
        }
        
        var max = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            max = Math.Max(max, resultArray[i]);
        }
        return max;
    }
}