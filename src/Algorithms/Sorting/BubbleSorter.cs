using System;
using System.Collections.Generic;

namespace Algorithms
{
    public class BubbleSorter
    {
        public List<int> Sort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 1; j < list.Count - i; j++)
                {
                    if (list[j - 1] > list[j])
                    {
                        var temp = list[j];
                        list[j] = list[j - 1];
                        list[j - 1] = temp;
                    }   
                }
            }

            return list;
        }
    }
}
