using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Dynamic
{
    internal class ClimbingStairsProblem
    {
        public int ClimbStairs(int n)
        {
            Dictionary<int, int> memo = new Dictionary<int, int>();
            return Fib(n + 1, memo);

        }

        public int Fib(int n, Dictionary<int, int> memo)
        {
            if(n <= 1) return n; 
            if(memo.TryGetValue(n, out int ans)) return ans;
            int fibSum = Fib(n - 1, memo) + Fib(n - 2, memo);
            memo.Add(n, fibSum);
            return fibSum;
        }
    }
}
