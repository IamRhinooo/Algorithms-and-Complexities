using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * This program is designed to sort and search through stock data using merge sort and linear or binary search.
 * The user can choose which stock data to sort and search through, and the program will display the results.
 * The user can also choose the order in which the stock data is sorted and the algorithm used to search.
 */

namespace Algorithms_and_Complexities
{
    class Program
    {
        static void Main(string[] args)
        {
            bool user = true;

            while (user)
            {
                bool display = true;

                while (display)
                {
                    Console.WriteLine("\nWhich of the following would you like to view: ");
                    Console.WriteLine("1 - Share 1 stocks in ascending order");
                    Console.WriteLine("2 - Share 1 stocks in descending order");
                    Console.WriteLine("3 - Share 2 stocks in ascending order");
                    Console.WriteLine("4 - Share 2 stocks in descending order");
                    Console.WriteLine("5 - Share 3 stocks in ascending order");
                    Console.WriteLine("6 - Share 3 stocks in descending order");
                    Console.WriteLine("7 - Share 4 stocks in ascending order");
                    Console.WriteLine("8 - Share 4 stocks in descending order");
                    Console.WriteLine("9 - Share 5 stocks in ascending order");
                    Console.WriteLine("10 - Share 5 stocks in descending order");
                    Console.WriteLine("11 - Share 6 stocks in ascending order");
                    Console.WriteLine("12 - Share 6 stocks in descending order");
                    Console.WriteLine("13 - Exit");

                    string strChoice = Console.ReadLine();
                    int.TryParse(strChoice, out int choice);

                    int[] list = new int[0];

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("The share 1 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share1, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share1;
                            break;
                        case 2:
                            Console.WriteLine("The share 1 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share1, MergeSort.SortOrder.Descending));
                            list = Stocks.Share1;
                            break;
                        case 3:
                            Console.WriteLine("The share 2 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share2, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share2;
                            break;
                        case 4:
                            Console.WriteLine("The share 2 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share2, MergeSort.SortOrder.Descending));
                            list = Stocks.Share2;
                            break;
                        case 5:
                            Console.WriteLine("The share 3 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share3, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share3;
                            break;
                        case 6:
                            Console.WriteLine("The share 3 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share3, MergeSort.SortOrder.Descending));
                            list = Stocks.Share3;
                            break;
                        case 7:
                            Console.WriteLine("The share 4 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share4, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share4;
                            break;
                        case 8:
                            Console.WriteLine("The share 4 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share4, MergeSort.SortOrder.Descending));
                            list = Stocks.Share4;
                            break;
                        case 9:
                            Console.WriteLine("The share 5 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share5, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share5;
                            break;
                        case 10:
                            Console.WriteLine("The share 5 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share5, MergeSort.SortOrder.Descending));
                            list = Stocks.Share5;
                            break;
                        case 11:
                            Console.WriteLine("The share 6 stocks after merge sort in ascending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share6, MergeSort.SortOrder.Ascending));
                            list = Stocks.Share6;
                            break;
                        case 12:
                            Console.WriteLine("The share 6 stocks after merge sort in descending order are:");
                            DisplaySortedStocks(MergeSort.MergingSort(Stocks.Share6, MergeSort.SortOrder.Descending));
                            list = Stocks.Share6;
                            break;
                        case 13:
                            display = false;
                            user = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }
                    //DisplaySortedStocks(list);

                    Console.WriteLine("What algorithm would you like to use?");
                    Console.WriteLine("1 - Linear Search\n2 - Binary Search");
                    string strSearchChoice = Console.ReadLine();
                    int.TryParse(strSearchChoice, out int searchChoice);

                    Console.WriteLine("What would you like to search for?: ");
                    string strSearch = Console.ReadLine();
                    int search = -1;
                    try { search = int.Parse(strSearch); }
                    catch (FormatException) { Console.WriteLine("Invalid input. Please try again."); continue; }

                    int[] results = new int[0];

                    if (searchChoice == 1)
                    {
                        results = Search.LinearSearch(list, search);
                    } 
                    else if (searchChoice == 2)
                    {
                        results = Search.BinarySearch(list, search);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                    }

                    if (results.Length > 0)
                    {
                        Console.WriteLine("The stock was found at the following indices: ");
                        Console.WriteLine(string.Join(", ", results));
                    }
                    else
                    {
                        int[] upperResults = new int[0];
                        int[] lowerResults = new int[0];

                        int Upper = search + 1;
                        int Lower = search - 1;

                        while (upperResults.Length == 0 || lowerResults.Length == 0)
                        {
                            bool upperLimit = false;
                            bool lowerLimit = false;

                            upperResults = searchChoice == 0 ? Search.LinearSearch(list, Upper) : Search.BinarySearch(list, Upper);

                            lowerResults = searchChoice == 0 ? Search.LinearSearch(list, Lower) : Search.BinarySearch(list, Lower);

                            if (upperResults.Length > 0)
                            {
                                Console.WriteLine("The closest stock found was: " +Upper + " at index: " +string.Join(", ", upperResults));
                            }

                            else
                            {
                                if (Upper < list.Max())
                                {
                                    Upper++;
                                }

                                else
                                {
                                    upperLimit = true;
                                }
                            }

                            if (lowerResults.Length > 0)
                            {
                                if (upperResults.Length > 0)
                                {
                                    Console.WriteLine("The closest stock found was also: " + Lower + " at index: " + string.Join(", ", lowerResults));
                                }
                                else
                                {
                                    Console.WriteLine("The closest stock found was: " + Lower + " at index: " + string.Join(", ", lowerResults));
                                }
                            }

                            if (upperResults.Length > 0 || lowerResults.Length > 0)
                            {
                                break;
                            }

                            else
                            {
                                if (Lower > 0)
                                {
                                    Lower--;
                                }

                                else
                                {
                                    lowerLimit = true;
                                }
                            }

                            if (upperLimit && lowerLimit)
                            {
                                Console.WriteLine("The stock was not found in the list.");
                                break;
                            }
                        }
                    }
                }
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
