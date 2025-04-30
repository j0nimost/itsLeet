namespace ItsLeet.Sorting
{
    internal class MergeSortAlgorithm
    {
        public void Sort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = l + (r - l) / 2;
                Sort(arr, l, m);
                Sort(arr, m+1, r);
                // merge arrays

                Merge(arr, l, m, r);
            }

        }

        private static void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] lArr = new int[n1];
            int[] rArr = new int[n2];

            System.Array.Copy(arr, l, lArr, 0, n1);
            System.Array.Copy(arr, m+1, rArr, 0, n2);

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
