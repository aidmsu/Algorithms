using System.Collections.Generic;
using Algorithms.Sorting;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks
{
    public class SorterBenchmarks
    {
        [Params(10, 100)]
        public int N;

        private int[] _sortingList;

        [GlobalSetup]
        public void GlobalSetup()
        {
            _sortingList = new int[N]; 

            for (int i = 0; i < _sortingList.Length; i++)
            {
                _sortingList[i] = N - i;
            }
        }

        [Benchmark]
        public IList<int> BubbleSorting()
        {
            return _sortingList.BubbleSort();
        }

        [Benchmark]
        public IList<int> SelectionSorting()
        {
            return _sortingList.SelectionSort();
        }

        [Benchmark]
        public IList<int> InsertionSorting()
        {
            return _sortingList.InsertionSort();
        }
    }
}
