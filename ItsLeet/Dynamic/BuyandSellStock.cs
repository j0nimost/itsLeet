using System.Numerics;

namespace ItsLeet.Dynamic;

public class BuyandSellStock
{
    [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
    public int MaxProfit(int[] prices)
    {

        var i = 0;
        var (max, min) = (0, prices[0]);

        while (i < prices.Length)
        {
           var x = System.Runtime.CompilerServices.Unsafe.Add(
                ref System.Runtime.InteropServices.MemoryMarshal.GetArrayDataReference(prices), i);
            if (x < min)
            {
                min = x;
            }

            max = Math.Max(x - min, max);
            i++;
        }

        return max;
    }
}