namespace ItsLeet.Graph;

public class FindCenterOfStarGraph
{
    public int FindCenter(int[][] edges)
    {
        var starSet = new Dictionary<int, int>(edges.Length * 2);
        
        var max = 0;
        var centre = 0;
        for (var i = 0; i < edges.Length; i++)
        {
            if (!starSet.TryAdd(edges[i][0], 1))
            {
                starSet[edges[i][0]] += 1;
                if (starSet[edges[i][0]] > max)
                {
                    max = starSet[edges[i][0]];
                    centre = edges[i][0];
                }
            }

            if (starSet.TryAdd(edges[i][1], 1))
            {
                starSet[edges[i][1]] += 1;
                if (starSet[edges[i][1]] > max)
                {
                    max = starSet[edges[i][1]];
                    centre = edges[i][1];
                }
            }
        }


        return centre;
    }
}