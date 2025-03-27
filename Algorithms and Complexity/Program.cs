using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
* Program Name: Algorithms and Complexities
* Author: Reuben Hover
* Date: 27/03/2025
*
* Description:
* This program is designed to read stock exhange data from 6 different  
* data files. The data is then sorted in ascending and descending order
* and will be displayed to the user with the option of the order and 
* what they would like to search for. They can also choose what search 
* method they would like to use.
*
* Main Functionality:
* - Reads stock exchange volume data from multiple text files.
* - Sorts and displays the data in ascending and descending order.
* - Displays every 10th (for smaller datasets) or 50th (for larger
datasets) value after sorting.
* - Searches for a user-defined value and returns its position(s).
* - If the value is not found, provides the nearest value(s) and their
position(s).
*
* Input Parameters:
* - Input file(s) or path
* - Ascending or descending order selection
* - Searching algorithm selection 
*
* Expected Output:
* - Sorted data with selected interval values displayed.
* - Ascending and descending values.
* - Binary and Linear search results.
*
* Implemented Algorithms:
* - Sorting: Bubble Sort, Merge Sort 
* - Searching: Linear Search, Binary Search
*/

namespace Algorithms_and_Complexities
{
    class Program
    {
        static void Main(string[] args)
        {
            bool user = true;

            // While loop to keep the program running until the user decides to exit
            while (user)
            {
                bool display = true;

                while (display)
                {
                    // Contains all the stock choices for the user to select from
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

                    // Error handles for "Jeff" inputs
                    string strChoice = Console.ReadLine();
                    int.TryParse(strChoice, out int choice);

                    int[] list = new int[0];

                    // Large choice of options for ascending and descending stocks lists
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
                            user = false;
                            display = false;
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }
                    // Error handling for checking the original lists
                    // DisplaySortedStocks(list);

                    // Asks what searching algorithm the user would like to use
                    Console.WriteLine("What algorithm would you like to use?");
                    Console.WriteLine("1 - Linear Search\n2 - Binary Search");

                    // Error handling for the searching algorithm
                    string strSearchChoice = Console.ReadLine();
                    int.TryParse(strSearchChoice, out int searchChoice);

                    // Asks what number the user would like to search for
                    Console.WriteLine("What would you like to search for?: ");
                    string strSearch = Console.ReadLine();
                    int search = -1;

                    // Error handling for the search input
                    try { search = int.Parse(strSearch); }
                    catch (FormatException) { Console.WriteLine("Invalid input. Please try again."); continue; }

                    int[] results = new int[0];

                    // Links to Linear
                    if (searchChoice == 1)
                    {
                        results = Search.LinearSearch(list, search);
                    }
                    // Links to Binary
                    else if (searchChoice == 2)
                    {
                        results = Search.BinarySearch(list, search);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue;
                    }
                    // If > 0 then it has found a stock
                    if (results.Length > 0)
                    {
                        Console.WriteLine("The stock was found at the following indices: ");
                        Console.WriteLine(string.Join(", ", results));
                    }
                    else
                    {
                        // If not found then it will search for the closest stock
                        int[] upperResults = new int[0];
                        int[] lowerResults = new int[0];

                        int Upper = search + 1;
                        int Lower = search - 1;

                        // While loop to keep searching for the closest stock
                        while (upperResults.Length == 0 || lowerResults.Length == 0)
                        {
                            bool upperLimit = false;
                            bool lowerLimit = false;

                            // If the stock is found then it will display the stock
                            upperResults = searchChoice == 0 ? Search.LinearSearch(list, Upper) : Search.BinarySearch(list, Upper);

                            // If the stock is found then it will display the stock
                            lowerResults = searchChoice == 0 ? Search.LinearSearch(list, Lower) : Search.BinarySearch(list, Lower);

                            // If the upper stock is found then it will display the stock
                            if (upperResults.Length > 0)
                            {
                                Console.WriteLine("The closest stock found was: " + Upper + " at index: " + string.Join(", ", upperResults));
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

                            // If the lower stock is found it will check whether the upper stock is also found or not.
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
                            // If found, it will break the loop
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
                            // If it is not found in the list.
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

        // Displays the 10th stock for the first set of arrays
        static void DisplaySortedStocks(int[] stocks)
        {
            var TenthStock = new List<int>();
            for (int i = 9; i < stocks.Length; i += 10)
            {
                TenthStock.Add(stocks[i]);
            }
            Console.WriteLine(string.Join(", ", TenthStock));
        }

        // Displays the 50th stock for the second set of arrays
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