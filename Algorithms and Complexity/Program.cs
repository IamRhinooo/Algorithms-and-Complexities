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
            var share1_ascending = Sort.MergeSort(Stocks.Share1, Sort.SortOrder.Ascending);
            var share1_descending = Sort.MergeSort(Stocks.Share1, Sort.SortOrder.Descending);

            var share2_ascending = Sort.MergeSort(Stocks.Share2, Sort.SortOrder.Ascending);
            var share2_descending = Sort.MergeSort(Stocks.Share2, Sort.SortOrder.Descending);

            var share3_ascending = Sort.MergeSort(Stocks.Share3, Sort.SortOrder.Ascending);
            var share3_descending = Sort.MergeSort(Stocks.Share3, Sort.SortOrder.Descending);

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
        }

        static void DisplaySortedStocks(List<int> stocks)
        {
            foreach (var stock in stocks)
            {
                Console.WriteLine(stock);
            }
        }
    }
}
