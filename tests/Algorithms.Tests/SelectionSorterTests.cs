﻿using Algorithms.Sorting;
using Xunit;

namespace Algorithms.Tests
{
    public class SelectionSorterTests
    {
        [Fact]
        public void SelectionSorter_Sort1()
        {
            var result = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.SelectionSort();

            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }

        [Fact]
        public void SelectionSorter_Sort2()
        {
            var result = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }.SelectionSort();
            Assert.Equal(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, result);
        }
    }
}
