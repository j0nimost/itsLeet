namespace ItsLeet.GeneralQuestions;

public class Sqrt
{
    public int MySqrt(int x)
    {
        var additionBase = 0.5;
        var i = 0.0;
        while (i * i <= x)
        {
            i+= additionBase;
        }
        i-=additionBase;
        return (int)Math.Floor(i);
    }
}