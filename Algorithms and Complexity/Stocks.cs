using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexities
{
    class Stocks
    {
        public static string[] share1;
        public static string[] share2;
        public static string[] share3;

        static Stocks()
        {
            share1 = File.ReadAllLines("share_1_256.txt");
            share2 = File.ReadAllLines("share_2_256.txt");
            share3 = File.ReadAllLines("share_3_256.txt");

            Convert.ToInt32(share1[0]);
            Convert.ToInt32(share2[0]);
            Convert.ToInt32(share3[0]);
        }
    }
}
