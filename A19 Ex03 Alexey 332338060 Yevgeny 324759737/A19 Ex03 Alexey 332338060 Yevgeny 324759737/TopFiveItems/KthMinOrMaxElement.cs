using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19_Ex03_Alexey_332338060_Yevgeny_324759737

{
    public static class KthMinOrMaxElement
    {
        // ------------------------------------------------------------------------------------
        // -- This algorithm is known by name K’th Smallest/Largest Element in Unsorted Array. 
        // -- The implementation is taken from 
        // -- https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array-set-2-expected-linear-time/
        // -- Avoiding  copyrights violation, no code changes ( apart from swap method and usage of List<int> instead of array as k-th smallest parameter) were made.
        // ------------------------------------------------------------------------------------

        public static int kthSmallest(List<int> arr, int l, int r, int k)
        {
            // If k is smaller than number of elements in array 
            if (k > 0 && k <= r - l + 1)
            {
                // Partition the array around last element and get 
                // position of pivot element in sorted array 
                int pos = partition(arr, l, r);

                // If position is same as k 
                if (pos - l == k - 1)
                    return pos;
                if (pos - l > k - 1)  // If position is more, recur for left subarray 
                    return kthSmallest(arr, l, pos - 1, k);

                // Else recur for right subarray 
                return kthSmallest(arr, pos + 1, r, k - pos + l - 1);
            }

            // If k is more than number of elements in array 
            return -1;
        }



        private static void swap<T>(List<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        // Standard partition process of QuickSort().  It considers the last 
        // element as pivot and moves all smaller element to left of it 
        // and greater elements to right 
        private static int partition(List<int> arr, int l, int r)
        {
            int x = arr[r], i = l;
            for (int j = l; j <= r - 1; j++)
            {
                if (arr[j] <= x)
                {
                    swap(arr, i, j);
                    i++;
                }
            }
            swap(arr, i, r);
            return i;
        }
    }
}
