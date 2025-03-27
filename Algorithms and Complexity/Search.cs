namespace Algorithms_and_Complexities
{
    class Search
    {
        public static int[] LinearSearch(int[] list, int searchValue)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] == searchValue)
                    indexes.Add(i);
            }
            return indexes.ToArray();
        }
        public static int[] BinarySearch(int[] list, int searchValue)
        {
            int[][] encodedList = BinaryEncoder(list);

            int left = 0;
            int right = encodedList.Length - 1;

            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (encodedList[middle][0] == searchValue)
                {
                    List<int> indexes = new List<int>();
                    indexes.Add(encodedList[middle][1]);
                    for (int i = middle - 1; i >= 0; i--)
                    {
                        if (encodedList[i][0] == searchValue)
                            indexes.Add(encodedList[i][1]);
                        else
                            break;
                    }
                    for (int i = middle + 1; i < encodedList.Length; i++)
                    {
                        if (encodedList[i][0] == searchValue)
                            indexes.Add(encodedList[i][1]);
                        else
                            break;
                    }
                    return indexes.ToArray();
                }
                else if (encodedList[middle][0] < searchValue)
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            return new int[0];
        }
        public static int[][] BinaryEncoder(int[] list)
        {
            int[][] binaryList = new int[list.Length][];

            for (int i = 0; i < list.Length; i++)
            {
                int[] ints = new int[2];
                ints[0] = list[i];
                ints[1] = i;

                binaryList[i] = ints;
            }
            for (int i = 0; i < binaryList.Length; i++)
            {
                for (int j = 0; j < binaryList.Length - 1; j++)
                {
                    if (binaryList[j][0] > binaryList[j + 1][0])
                    {
                        int[] temp = binaryList[j];
                        binaryList[j] = binaryList[j + 1];
                        binaryList[j + 1] = temp;
                    }
                }
            }
            return binaryList;
        }
    }
}