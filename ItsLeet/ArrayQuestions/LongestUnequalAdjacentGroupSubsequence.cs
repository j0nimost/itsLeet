namespace ItsLeet.ArrayQuestions;

public class LongestUnequalAdjacentGroupSubsequence
{
    public IList<string> GetLongestSubsequence(string[] words, int[] groups) {

        if (words.Length == 1)
        {
            return words;
        }
        var result = new HashSet<string>(words.Length);
        result.Add(words[0]);

        var (i, p) = (0, 0);
        while (i < groups.Length)
        {
            if (groups[p] != groups[i])
            {
                result.Add(words[i]);
                result.Add(words[p]);
                p = i;
            }

            i++;
        }

        
        return result.ToList();
    }
}