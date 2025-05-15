namespace ItsLeet.ArrayQuestions;

public class NumberOfEQDominoPairs
{
    // TODO: Complete
    public int NumEquivDominoPairs(int[][] dominoes) {
        var pairDict = new Dictionary<string, int>();
        for (var i = 0; i < dominoes.Length; i++)
        {
            var key1 = $"{dominoes[i][0]}{dominoes[i][1]}";
            var key2 = $"{dominoes[i][1]}{dominoes[i][0]}";
            
            if(pairDict.ContainsKey(key1))
                pairDict[key1]++;
            else if (pairDict.ContainsKey(key2))
                pairDict[key2]++;
            else
                pairDict.Add(key1, 1);
        }
        var count = 0;
        foreach (var pair in pairDict)
            count += pair.Value;
        return count;
    }
}