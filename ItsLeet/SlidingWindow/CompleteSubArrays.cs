namespace ItsLeet.SlidingWindow;

public class CompleteSubArrays
{
    public int CountCompleteSubarrays(int[] nums) {
        var uniqueValues = new HashSet<int>(nums.Length);
        var result = 0;
        foreach (var t in nums)
        {
            uniqueValues.Add(t);
        }
        var uniqueValuesCount = uniqueValues.Count;
        uniqueValues.Clear();
        var p = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            p = i;
            while (p < nums.Length)
            {
                uniqueValues.Add(nums[p]);
                if (uniqueValues.Count == uniqueValuesCount)
                {
                    result++;
                }
                p++;
            }
            uniqueValues.Clear();
        }
        
        return result;
    }
}