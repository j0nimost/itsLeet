namespace ItsLeet.ArrayQuestions;

public class MaximumValueOrderedTriplet
{
    public long MaximumTripletValue(int[] nums) {
        // keep indexes i, j and k inorder
        // i < j < k
        // (nums[i] - nums[j]) * nums[k]
        long max = 0;

        for (var l = 0; l < nums.Length; l++)
        {
            var j=l+1;
            var minIndex = j;
            var min = int.MaxValue; 
            while (j+1 < nums.Length)
            {
                if (nums[j] < min)
                {
                    min = Math.Min(min, nums[j]);
                    minIndex = j;
                    
                    var k = minIndex+1;
                    // Console.WriteLine(nums[l] + " " + min);
                    while (k < nums.Length)
                    {
                        long orderedTriplet = (nums[l] - min) ;
                        max = Math.Max((long)max, (long)orderedTriplet * nums[k]);
                        Console.WriteLine(nums[l] + " " + min + " " + nums[k]);
                        k++;
                    }
                }
                j++;
            }

        }
        
        return max;
    }
}