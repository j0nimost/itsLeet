namespace ItsLeet.Dynamic;

public class PushingDominoes
{
    // TODO: Complete this challenge
    public string PushDominoes(string dominoes) {
        var dominoesArray = dominoes.ToCharArray();
        var (l, r) = (0, 0);

        while (l <= r)
        {
            if (dominoesArray[l] == 'L')
                l++;
            if (dominoesArray[r] == 'R')
                r++;
        }
        return string.Empty;
    }
}