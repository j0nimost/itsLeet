namespace ItsLeet.Graph;

public class FindTownJudge
{
    public int FindJudge(int n, int[][] trust)
    {
        var vertices = new Dictionary<int, int>(n);

        for (var i = 0; i < n; i++)
        {
            vertices[i + 1] = 0;
        }

        foreach (var i in trust)
        {
            vertices[i[0]] -= 1;
            vertices[i[1]] += 1;
        }

        foreach (var (k, v) in vertices)
        {
            if (v == n-1)
            {
                return k;
            }
        }

        return -1;
    }
}