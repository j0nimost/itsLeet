namespace ItsLeet.GeneralQuestions;

public class Plus
{
    public int[] PlusOne(int[] digits)
    {
        if (digits.Length == 1 && digits[0] == 9)
        {
            return [1,0];
        }
        
        if (digits[^1] < 9)
        {
            digits[^1]++;
            return digits;
        }
        
        var newDigits = new int[digits.Length + 1];
        var carry = 1;
        for (var i = digits.Length-1; i >= 0; i--)
        {
            if (digits[i] == 9 && (digits.Length-1 ==i || carry == 1))
            {
                newDigits[i+1] = 0;
                carry = 1;
                continue;
            }

            if (carry == 1)
            {
                newDigits[i+1] += carry + digits[i];
                carry = 0;
                continue;
            }

            newDigits[i + 1] += digits[i];
        }

        if (carry == 1)
        {
            newDigits[0] = 1;
        }

        return newDigits[0] == 0 ? newDigits[1..] : newDigits;
    }
}