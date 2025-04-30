using System.Text;

namespace ItsLeet.String;

public class ParseInt
{
    public int MyAtoi(string s)
    {
        int i = 0;
        StringBuilder stringBuilder = new StringBuilder();
        bool isNegative = false;
        while (i < s.Length)
        {
            if (s[i] - '0' >= 0 && s[i] - '0' <= 9)
            {
                while (i < s.Length && (s[i] - '0' >= 0 && s[i] - '0' <= 9))
                {
                    stringBuilder.Append(s[i]);
                    i++;
                }
                
                continue;
            }
            else if (s[i] == '-' && i+1 < s.Length)
            {
                // peek next

                if (s[i + 1] - '0' >= 0 && s[i + 1] - '0' <= 9)
                {
                    isNegative = true;
                }
            }

            i++;
        }
        
        // form string
        var resultStr = stringBuilder.ToString();
        var result = int.Parse(resultStr);

        return isNegative ? -result : result;
    }
}