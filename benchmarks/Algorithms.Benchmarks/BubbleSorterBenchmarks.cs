﻿using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Algorithms.Benchmarks
{
    public class BubbleSorterBenchmarks
    {
        [Params(10, 100, 1000)]
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
    }
}
