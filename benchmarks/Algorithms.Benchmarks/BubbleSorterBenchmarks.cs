using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks
{
    public class BubbleSorterBenchmarks
    {
        private static readonly BubbleSorter BubbleSorter = new BubbleSorter();
        private static readonly List<int> SortingList;
        private static readonly List<int> SortingList1;

        static BubbleSorterBenchmarks()
        {
            SortingList = new List<int>();
            SortingList1 = new List<int>();

            var count = 1000;
            for (int i = 0; i < count; i++)
            {
                SortingList.Add(i);
                SortingList1.Add(count - i);
            }
        }

        [Benchmark]
        public List<int> BubbleSorting()
        {
            return BubbleSorter.Sort(SortingList);
        }

        [Benchmark]
        public List<int> BubbleSorting1()
        {
            return BubbleSorter.Sort(SortingList1);
        }
    }
}
