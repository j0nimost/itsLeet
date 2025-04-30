namespace ItsLeet.Dynamic;

public class CombinatorSum
{
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        var sumCombinator = new List<IList<int>>();

        for (int i = 0; i < candidates.Length; i++)
        {
            var result = Combinator(candidates, target, i, new List<int>());
            for (int j = 0; j < result.Count; j++)
            {
                target -= result[j];
            }

            if (target == 0)
            {
                sumCombinator.Add(result);
            }
        }
        return sumCombinator;
    }

    private List<int> Combinator(int[] candidate, int target, int index, List<int> sumCombinator)
    {
        for (var i = index; i < candidate.Length; i++)
        {
            if (target - candidate[i] < 0)
            {
                continue;
            }
            else
            {
                sumCombinator.Add(candidate[i]);
                target -= candidate[i];
                Combinator(candidate, target, i, sumCombinator); 
            }
        }

        return sumCombinator;
    }
    
}