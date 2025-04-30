namespace ItsLeet.Sorting;

public class MergeOwnMemoryImplementation
{
    public void Sort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            var m = l + (r - l) / 2;
            Sort(arr, l, m);
            Sort(arr, m+1, r);
            
            Merge(arr, l, m, r);
        }
    }

    public void Merge(int[] arr, int l, int m, int r)
    {
        var a1 = m - l + 1;
        var a2 = r - l;

        var arr1 = new int[a1];
        var arr2 = new int[a2];
        
        System.Array.Copy(arr, l, arr1, 0, a1);
        System.Array.Copy(arr, m, arr2, 0, a2);
        
        
        // merge
        int i=0 ,j = 0;
        var k = l;

        while (i < a1 && j < a2)
        {
            if (arr1[i] < arr2[j])
            {
                arr[k] = arr1[i];
                i++;
            }
            else
            {
                arr[k] = arr2[j];
                j++;
            }

            k++;
        }
        
        // check for remnants
        while (i < a1)
        {
            arr[k] = arr1[i];
            k++;
            i++;
        }

        while (j < a2)
        {
            arr[k] = arr2[j];
            k++;
            j++;
        }
    }
}