namespace ItsLeet.Dynamic;

public class BrainPower
{
    public long MostPoints(int[][] questions) 
    {
        // iterate consequentially
        // skip 2 indexes
        var max = 0;
        var results = new int[questions.Length];
        for (var i = 0; i < questions.Length; i++)
        {
            var j = i;
            var sum = 0;
            while (j < questions.Length)
            {
                // decide which question to take
                // if we skip current we can take next
                
                var pn = j + 1;
                var prevMax = questions[j][0];
                var prevMaxIndex = j;
                while (pn < questions.Length)
                {
                    if(questions[pn][0] > prevMax) {
                        prevMax = questions[pn][0];
                        prevMaxIndex = pn;
                    }
                    pn++;
                }

                pn = prevMaxIndex;
                var peekNext = prevMax;
                if(sum > 0)
                {
                    sum += peekNext;
                    j += questions[pn][1] + 1;
                    results[i] = sum;
                    continue;
                }
                sum += questions[j][0];
                Console.WriteLine($"i : {i} j : {j} sum : {sum}");
                j += questions[j][1] + 1;
                results[i] = sum;
            }
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
            max = Math.Max(max, result);
        }
        return max;
    }
}