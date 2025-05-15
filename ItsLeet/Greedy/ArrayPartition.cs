namespace ItsLeet.Greedy;

public class ArrayPartition
{
    public int ArrayPairSum(int[] nums) {
        MergeSort(nums, 0, nums.Length-1);
        var max = 0;

        Console.WriteLine();
        for (var i = 0; i < nums.Length; i+=2)
            max += Math.Min(nums[i], nums[i+1]);
        return max;
    }
    
    private void MergeSort(int[] nums, int start, int end)
    {
        if (start >= end) return;
        var mid = (start + end) / 2;
        MergeSort(nums, start, mid);
        MergeSort(nums, mid+1, end);
            
        Merge(nums, start, mid, end);
    }
    private void Merge(int[] nums, int start, int mid, int end)
    {
        var n1 = mid - start + 1;
        var n2 = end - mid;

        var leftArr = new int[n1];
        var rightArr = new int[n2];
        
        var (i, j) = (0, 0);
        
        // copy data 
        for(i =0; i < n1; i++)
            leftArr[i] = nums[start + i];
        for(j = 0; j < n2; j++)
            rightArr[j] = nums[mid + 1 + j];
        (i, j) = (0, 0);
        
        var k = start;
        while (i < n1 && j < n2)
        {
            if (leftArr[i] <= rightArr[j])
            {
                nums[k] = leftArr[i];
                i++;
            }
            else
            {
                nums[k] = rightArr[j];
                j++;
            }
            k++;
        }
        
        // copy remaining
        while (i < n1)
        {
            nums[k] = leftArr[i];
            i++;
            k++;
        }
        
        while (j < n2)
        {
            nums[k] = rightArr[j];
            j++;
            k++;
        }
    }
}