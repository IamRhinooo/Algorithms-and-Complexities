using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_and_Complexities
{
    class Stocks
    {
        public static List<int> Share1 { get; private set; }
        public static List<int> Share2 { get; private set; }
        public static List<int> Share3 { get; private set; }

        static Stocks()
        {
            Share1 = File.ReadAllLines("share_1_256.txt").Select(int.Parse).ToList();
            Share2 = File.ReadAllLines("share_2_256.txt").Select(int.Parse).ToList();
            Share3 = File.ReadAllLines("share_3_256.txt").Select(int.Parse).ToList();
        }
    }
}
