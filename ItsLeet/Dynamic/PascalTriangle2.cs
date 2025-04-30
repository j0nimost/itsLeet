namespace ItsLeet.Dynamic;

public class PascalTriangle2
{
    public IList<int> GetRow(int rowIndex) {
        
        var input = new List<int>(){1,1};

        for(var i=1; i < rowIndex; ++i)
        {
            input = PascalTriangle(input);
        }

        return input;
    }

    private List<int> PascalTriangle(List<int> input)
    {
        var newResult = new List<int>(input.Count() + 1);
        newResult.Add(1);

        var i=0;
        while(i < input.Count() && i+1 < input.Count())
        {
            //take 2 and sum
            newResult.Add(input[i] + input[i+1]);
            i++;
        }
        newResult.Add(1);

        return newResult;
    }
}