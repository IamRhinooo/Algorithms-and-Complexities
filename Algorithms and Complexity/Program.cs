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
            Console.WriteLine("The share 1 stocks are:");
            foreach (var line in Stocks.share1)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("The share 2 stocks are:");
            foreach (var line in Stocks.share2)
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("The share 3 stocks are:");
            foreach (var line in Stocks.share3)
            {
                Console.WriteLine(line);
            }
        }
    }
}
