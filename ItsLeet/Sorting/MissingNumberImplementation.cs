namespace ItsLeet.Sorting;

public class MissingNumberImplementation
{
    public int MissingNumber(int[] nums) 
    {
        // binary sort
        SortResults(nums,0, nums.Length-1);

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != i)
            {
                return i;
            }
        }
        

        return nums.Length;
    }

    private void SortResults(int[] nums, int l, int h)
    {
        if(l >= h)
            return;
        var m = l + (h - l) / 2;
        SortResults(nums, l, m);
        SortResults(nums, m+1, h);
        MergeSort(nums, l, m, h);
    }

    private void MergeSort(int[] nums, int l, int m, int h)
    {
        var n1 = m - l + 1;
        var n2 = h - m;

        var lArr = new int[n1];
        var rArr = new int[n2];

        int i;
        int j;

        for (i = 0; i < n1; ++i)
        {
            lArr[i] = nums[l + i];
        }

        for (j = 0; j < n2; ++j)
        {
            rArr[j] = nums[m + 1 + j];
        }

        (i, j) = (0, 0);
        var k = l;

        while (i < n1 && j < n2)
        {
            if (lArr[i] <= rArr[j])
            {
                nums[k] = lArr[i];
                i++;
            }
            else
            {
                nums[k] = rArr[j];
                j++;
            }

            k++;
        }

        while (i<n1)
        {
            nums[k] = lArr[i];
            i++;
            k++;
        }

        while (j<n2)
        {
            nums[k] = rArr[j];
            j++;
            k++;
        }
    }
}