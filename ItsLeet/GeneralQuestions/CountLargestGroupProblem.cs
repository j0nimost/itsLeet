using System.Reflection.Metadata.Ecma335;

namespace ItsLeet.GeneralQuestions;

public class CountLargestGroupProblem
{
    public int CountLargestGroup(int n) {
        // generate arrays from a given number
        // find groups where a number is a sum of other digits
        // return the length of the largest group
        if (n < 10)
        {
            return n;
        }
        var result = new Dictionary<int, int>();
        for (var i = 1; i <= n; i++)
        {
            var temp = i;
            var sumn = 0;
            while (temp > 0)
            {
                sumn += temp % 10;
                temp /= 10;
            }
            
            result.TryAdd(sumn, 1);
            result[sumn] += 1;
            
        }

        var maxLength = 1;
        var count = 1;
        foreach (var (k,vi) in result)
        {
            if (vi > maxLength)
            {
                maxLength = vi;
                count = 1;
                continue;
            }

            if (vi == maxLength)
            {
                count++;
            }
        }
        return count;
    }
}