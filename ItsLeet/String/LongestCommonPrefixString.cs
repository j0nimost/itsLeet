using System.Text;

namespace ItsLeet.String;

public class LongestCommonPrefixString
{
    public string LongestCommonPrefix(string[] strs)
    {
        switch (strs.Length)
        {
            case 0:
                return string.Empty;
            case 1:
                return strs[0];
        }

        var longestSubstr = new Dictionary<string, int>(1024);
        var c = 1;
        while (true)
        {
            var isMatching = false;
            foreach (var str in strs)
            {
                if (c > str.Length)
                {
                    continue;
                }
                var strsSub = str[..c];
                if (!longestSubstr.TryAdd(strsSub, 1))
                {
                    longestSubstr[strsSub] += 1;
                }
                isMatching = true;

            }

            if (!isMatching)
            {
                break;
            }
            c++;
        }

        var maxCount = 2;
        var subStringLength = 1;
        var prefix = string.Empty;
        foreach (var (k,v) in longestSubstr)
        {
            if (v < maxCount && subStringLength <= k.Length) 
                continue;
            maxCount = v;
            prefix = k;
            subStringLength = k.Length;
        }

        return prefix;
    }
}