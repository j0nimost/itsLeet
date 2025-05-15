using System.Text;

namespace ItsLeet.HashTable;

public class TotalCharactersAfterTransformation1
{
    //TODO: 3335 Complete it
    public int LengthAfterTransformations(string s, int t) {
        var modulo = 1_000_000_007;
        long sum = 0;

        if (s.Length == 1)
        {
            if ('z' - s[0] < t)
            {
                // sum += 1;
                t -= 'z' - s[0];
                s = "ab";
            }
            else 
                return 1;
        }
        var alphabetHash = new Dictionary<char, long>(26);
        for (var i = 0; i < 26; i++)
            alphabetHash.Add((char)('a' + i), 0);
        
        // set the characters min value
        foreach (var c in s)
            alphabetHash[c] += 1;
        

        for (var i = 0; i < t; i++)
        {  
            foreach (var (c , j) in alphabetHash)
            {
                if (c == 'z' &&  j > 0)
                {
                    alphabetHash[c] -= 1;
                    alphabetHash['a'] += 1;
                    alphabetHash['b'] += 1;
                }
                else if (j > 0 && alphabetHash[(char)(c + 1)] == 0)
                {
                    alphabetHash[c] -= 1;
                    alphabetHash[(char)(c + 1)] += 1;
                    break;
                } else if (j > 0)
                {
                    alphabetHash[c] -= 1;
                    alphabetHash[(char)(c + 1)] += 1;
                }
            }
        }
        
        foreach (var c in alphabetHash)
            sum += c.Value;
        
        
        return (int)(sum % modulo);
    }
}