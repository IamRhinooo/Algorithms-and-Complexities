using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexities
{
    class MergeSort
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public static int[] MergingSort(int[] unsorted, SortOrder order = SortOrder.Ascending)
        {
            if (unsorted.Length <= 1)
                return unsorted;

            int middle = unsorted.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[unsorted.Length - middle];

            Array.Copy(unsorted, 0, left, 0, middle);
            Array.Copy(unsorted, middle, right, 0, unsorted.Length - middle);

            left = MergingSort(left, order);
            right = MergingSort(right, order);
            return Merge(left, right, order);
        }

        private static int[] Merge(int[] left, int[] right, SortOrder order)
        {
            int[] result = new int[left.Length + right.Length];
            int leftIndex = 0, rightIndex = 0, resultIndex = 0;

            while (leftIndex < left.Length && rightIndex < right.Length)
            {
                if ((order == SortOrder.Ascending && left[leftIndex] <= right[rightIndex]) ||
                    (order == SortOrder.Descending && left[leftIndex] >= right[rightIndex]))
                {
                    result[resultIndex++] = left[leftIndex++];
                }
                else
                {
                    result[resultIndex++] = right[rightIndex++];
                }
            }

            while (leftIndex < left.Length)
            {
                result[resultIndex++] = left[leftIndex++];
            }

            while (rightIndex < right.Length)
            {
                result[resultIndex++] = right[rightIndex++];
            }

            return result;
        }
    }

    class Bubblesort
    {
        public static void BubblingSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
