using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class InsertionSorter
    {
        public static IList<int> Sort(IList<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                var x = list[i];

                int j = i - 1;

                while (j >= 0 && list[j] > x)
                {
                    list.Swap(j, j + 1);
                    j--;
                }

                list[j + 1] = x;
            }

            return list;
        }

        public static IList<int> InsertionSort(this IList<int> list) => Sort(list);
    }
}

