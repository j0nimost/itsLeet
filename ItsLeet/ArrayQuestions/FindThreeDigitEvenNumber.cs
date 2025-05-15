namespace ItsLeet.ArrayQuestions;

public class FindThreeDigitEvenNumber
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var results = new HashSet<int>(digits.Length);
        var divisibleNumbers = new List<int>();
        for (var i = 100; i < 1000; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            divisibleNumbers.Add(i);
        }
        
        MergSort(digits,0, digits.Length-1);

        foreach (var number in divisibleNumbers)
        {
            var hundreds = number / 100;
            var tens = number % 100 / 10;
            var ones = number % 10;

            var hundredsIndex = -1;
            var tensIndex = -1;
            var onesIndex = -1;
            for (var i = 0; i < digits.Length; i++)
            {
                if (digits[i] != hundreds) continue;
                hundredsIndex = i;
                break;
            }

            for (var i = 0; i < digits.Length; i++)
            {
                if(digits[i] != tens) continue;
                
                if(i == hundredsIndex) continue;
                tensIndex = i;
                break;
            }

            for (var i = 0; i < digits.Length; i++)
            {
                if(digits[i] != ones) continue;
                if(i == tensIndex || i == hundredsIndex) continue;
                onesIndex = i;
                break;
            }
            
            if(onesIndex == -1 || tensIndex == -1 || hundredsIndex == -1)
                continue;
            results.Add(number);
        }
        
        // sort it
        var resultArr = results.ToArray();

        MergSort(resultArr, 0, results.Count-1);
        return resultArr;
    }
    
    private void MergSort(int[] nums, int l, int r)
    {
        if (l < r)
        {
            var m = l + (r-l)/2;
            MergSort(nums, l, m);
            MergSort(nums, m+1, r);
            
            Merge(nums, l, m, r);;
        }
    }
    
    private void Merge(int[] nums, int l, int m, int r)
    {
        var n1 = m - l + 1;
        var n2 = r - m;
        var leftArr = new int[n1];
        var rightArr = new int[n2];

        var (i, j) = (0, 0);

        for (i= 0; i < n1; i++)
        {
            leftArr[i] = nums[l + i];
        }

        for (j = 0; j < n2; j++)
        {
            rightArr[j] = nums[m + 1 + j];
        }
        
        (i, j) = (0, 0);
        var k = l;
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
