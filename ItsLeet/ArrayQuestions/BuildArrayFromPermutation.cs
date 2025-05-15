namespace ItsLeet.ArrayQuestions;

public class BuildArrayFromPermutation
{
    public int[] BuildArray(int[] nums) {
        // [0,2,1,5,3,4]
        // [5,0,1,2,3,4]
        var result = new int[nums.Length];
        
        for (var i = 0; i < nums.Length; i++)
            result[i] = nums[nums[i]];
        return result;
        // try in O(1) space time
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     var temp = nums[i];
        //     var div = nums[temp] / 1000;
        //     var rem = nums[temp] % 1000;
        //     if (nums[temp] > 1000)
        //     {
        //         // div = nums[temp] / 1000;
        //         nums[temp] = div;
        //         // nums[i] *= 1000;
        //         nums[i] = nums[i] * 1000 + rem;
        //         continue;
        //     }
        //     nums[i] += nums[temp] * 1000;
        // }
        //
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     nums[i] %= 1000;
        // }
        // return nums;
    }
}