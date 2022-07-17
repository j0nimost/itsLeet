using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Sorting
{
    internal class MergeSortAlgorithm
    {
        public void sort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = l + (r - l) / 2;
                sort(arr, l, m);
                sort(arr, m+1, r);
                // merge arrays

                merge(arr, l, m, r);
            }

        }

        private void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] lArr = new int[n1];
            int[] rArr = new int[n2];

            Array.Copy(arr, l, lArr, 0, n1);
            Array.Copy(arr, m+1, rArr, 0, n2);

            int i=0,j =0;

            int k = l;

            while(i < n1 && j < n2)
            {
                if(lArr[i] <= rArr[j])
                {
                    arr[k] = lArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rArr[j];
                    j++;
                }
                k++;
            
            }

            while (i < n1)
            {
                arr[k] = lArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rArr[j];
                j++;
                k++;
            }
        }
    }
}
