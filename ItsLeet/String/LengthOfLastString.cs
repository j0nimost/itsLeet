using System.Runtime.CompilerServices;

namespace ItsLeet.String;

public class LengthOfLastString
{
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public int LengthOfLastWord(string s) {
        var wordCount = 0;
        var i = s.Length-1;
        while (i >= 0)
        {
            if (s[i] == ' ')
            {
                i--;
                continue;
            }

            while (i >=0 && s[i] != ' ')
            {
                wordCount++;
                i--;
            }

            if (wordCount > 0)
                break;
        }

        return wordCount;
    }
}