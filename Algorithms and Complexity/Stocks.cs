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
        public static int[] Share1 { get; private set; }
        public static int[] Share2 { get; private set; }
        public static int[] Share3 { get; private set; }

        public static int[] Share4 { get; private set; }
        public static int[] Share5 { get; private set; }
        public static int[] Share6 { get; private set; }

        static Stocks()
        {
            Share1 = File.ReadAllLines("share_1_256.txt").Select(int.Parse).ToArray();
            Share2 = File.ReadAllLines("share_2_256.txt").Select(int.Parse).ToArray();
            Share3 = File.ReadAllLines("share_3_256.txt").Select(int.Parse).ToArray();
            Share4 = File.ReadAllLines("share_1_2048.txt").Select(int.Parse).ToArray();
            Share5 = File.ReadAllLines("share_2_2048.txt").Select(int.Parse).ToArray();
            Share6 = File.ReadAllLines("share_3_2048.txt").Select(int.Parse).ToArray();
        }
    }
}
