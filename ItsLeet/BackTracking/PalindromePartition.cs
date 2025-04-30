namespace ItsLeet.BackTracking;

public class PalindromePartition
{
    public IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        Backtrack(s.ToCharArray(), 0, result);
        return result;
    }

    private void Backtrack(char[] s, int start, List<IList<string>> result)
    {
        if (start == s.Length)
        {
            result.Add(new List<string>(){string.Join("", s)});
            return;
        }

        for (var i = start; i < s.Length; i++)
        {
            // Swap(s,start, i);
            Backtrack(s, start+1, result);
            // Swap(s,start, i);
        }
    }
    
}