using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Dynamic
{
    public class UniquePathAlgorithm
    {
        private Dictionary<string, int> memo = new Dictionary<string, int>();
        public int UniquePaths(int m, int n)
        {
            string key = $"{m},{n}";
            if (m == 1) return m;
            if (n == 1) return n;
            
            if(memo.TryGetValue(key, out int x)) return x;
            int sum = UniquePaths(m - 1, n) + UniquePaths(m, n - 1);
            memo.Add(key, sum);
            return sum;
        }

    }
}
