using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Dynamic
{
    internal class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> pascalTriangle = new List<IList<int>>();

            pascalTriangle.Add(new List<int>() { 1 }); // since numrows >= 1
            

            if (numRows == 1)
                return (IList<IList<int>>)pascalTriangle;

            pascalTriangle.Add(new List<int>() { 1, 1 }); // for second row

            for (int i = 2; i < numRows; i++)
            {
                List<int> rowValues = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if(j == 0  || j == i)
                        rowValues.Add(1);
                    else if(j > 0)
                    {
                        IList<int> prev = pascalTriangle[i-1];
                        rowValues.Add(prev[j-1] + prev[j]);
                    }
                }

                pascalTriangle.Add(rowValues);
            }
            return pascalTriangle;
        }
    }
}
