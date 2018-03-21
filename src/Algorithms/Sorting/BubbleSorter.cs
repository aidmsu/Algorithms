using System.Collections.Generic;

namespace Algorithms
{
    public static class BubbleSorter
    {
        public static IList<int> Sort(IList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count - i; j++)
                {
                    if (list[j - 1] > list[j]) list.Swap(j - 1, j);
                }
            }

            return list;
        }

        public static IList<int> BubbleSort(this IList<int> list)
        {
            return Sort(list);
        }
    }
}
