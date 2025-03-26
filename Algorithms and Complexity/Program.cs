using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexities
{
    class Program
    {
        static void Main(string[] args)
        {
            var share1_ascending = MergeSort.MergingSort(Stocks.Share1, MergeSort.SortOrder.Ascending);
            var share1_descending = MergeSort.MergingSort(Stocks.Share1, MergeSort.SortOrder.Descending);

            var share2_ascending = MergeSort.MergingSort(Stocks.Share2, MergeSort.SortOrder.Ascending);
            var share2_descending = MergeSort.MergingSort(Stocks.Share2, MergeSort.SortOrder.Descending);

            var share3_ascending = MergeSort.MergingSort(Stocks.Share3, MergeSort.SortOrder.Ascending);
            var share3_descending = MergeSort.MergingSort(Stocks.Share3, MergeSort.SortOrder.Descending);

            Console.WriteLine("The share 1 stocks in ascending order are:");
            DisplaySortedStocks(share1_ascending);

            Console.WriteLine("The share 1 stocks in descending order are:");
            DisplaySortedStocks(share1_descending);

            Console.WriteLine("The share 2 stocks in ascending order are:");
            DisplaySortedStocks(share2_ascending);

            Console.WriteLine("The share 2 stocks in descending order are:");
            DisplaySortedStocks(share2_descending);

            Console.WriteLine("The share 3 stocks in ascending order are:");
            DisplaySortedStocks(share3_ascending);

            Console.WriteLine("The share 3 stocks in descending order are:");
            DisplaySortedStocks(share3_descending);

            if (Stocks.Share4 != null)
            {
                Bubblesort.BubblingSort(Stocks.Share4);
                Console.WriteLine("The share 4 stocks after bubble sort are:");
                Display50thSortedStocks(Stocks.Share4);
            }
            else
            {
                Console.WriteLine("Share 4 is not defined.");
            }

            if (Stocks.Share5 != null)
            {
                Bubblesort.BubblingSort(Stocks.Share5);
                Console.WriteLine("The share 5 stocks after bubble sort are:");
                Display50thSortedStocks(Stocks.Share5);
            }
            else
            {
                Console.WriteLine("Share 5 is not defined.");
            }

            if (Stocks.Share6 != null)
            {
                Bubblesort.BubblingSort(Stocks.Share4);
                Console.WriteLine("The share 6 stocks after bubble sort are:");
                Display50thSortedStocks(Stocks.Share4);
            }
            else
            {
                Console.WriteLine("Share 6 is not defined.");
            }
        }

        static void DisplaySortedStocks(int[] stocks)
        {
            var TenthStock = new List<int>();
            for (int i = 9; i < stocks.Length; i += 10)
            {
                TenthStock.Add(stocks[i]);
            }
            Console.WriteLine(string.Join(", ", TenthStock));
        }

        static void Display50thSortedStocks(int[] stocks)
        {
            var TenthStock = new List<int>();
            for (int i = 49; i < stocks.Length; i += 50)
            {
                TenthStock.Add(stocks[i]);
            }
            Console.WriteLine(string.Join(", ", TenthStock));
        }
    }
}
