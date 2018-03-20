using System.Collections.Generic;
using Xunit;

namespace Algorithms.Benchmarks
{
    public class BubbleSorterTests
    {
        [Fact]
        public void BubbleSorter_Sort1()
        {
            var sorter = new BubbleSorter();
            var result = sorter.Sort(new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            Assert.Equal(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [Fact]
        public void BubbleSorter_Sort2()
        {
            var sorter = new BubbleSorter();
            var result = sorter.Sort(new List<int> {10, 9, 8, 7, 6, 5, 4, 3, 2, 1});
            Assert.Equal(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }
    }
}
