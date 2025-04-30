namespace ItsLeet.ArrayQuestions;

public class FindNumbersWithEvenNumbers
{
    public int FindNumbers(int[] nums)
    {
        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            var divs = 0;
            while (nums[i] != 0)
            {
                divs++;
                nums[i] /= 10;
            }
            if(divs %2 == 0)
                count++;
        }
        return count;
    }
}