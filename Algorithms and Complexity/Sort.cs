using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexities
{
    class Sort
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }
        public static List<int> MergeSort(List<int> unsorted, SortOrder order = SortOrder.Ascending)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }
            left = MergeSort(left, order);
            right = MergeSort(right, order);
            return Merge(left, right, order);
        }

        private static List<int> Merge(List<int> left, List<int> right, SortOrder order)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if ((order == SortOrder.Ascending && left.First() <= right.First()) ||
                        (order == SortOrder.Descending && left.First() >= right.First()))
                    {
                        result.Add(left.First());
                        left.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(right.First());
                        right.RemoveAt(0);
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.RemoveAt(0);
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());
                    right.RemoveAt(0);
                }
            }
            return result;
        }
    }
}
