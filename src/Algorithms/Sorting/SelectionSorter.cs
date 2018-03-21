using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class SelectionSorter
    {
        public static IList<int> Sort(IList<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var iMin = i;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[j] < list[iMin]) iMin = j;
                }

                if(i != iMin)
                {
                    var temp = list[i];
                    list[i] = list[iMin];
                    list[iMin] = temp;
                }
            }
            return list;
        }

        public static IList<int> SelectionSort(this IList<int> list) => Sort(list);
    }
}
