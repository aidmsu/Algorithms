using System.Collections.Generic;

namespace Algorithms
{
    public static class IListExtensions
    {
        public static void Swap<T>(this IList<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
