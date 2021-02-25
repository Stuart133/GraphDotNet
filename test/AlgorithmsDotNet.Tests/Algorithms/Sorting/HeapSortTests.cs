﻿using AlgorithmsDotNet.Algorithms.Sorting;
using System.Linq;
using Xunit;

namespace AlgorithmsDotNet.Tests.Algorithms.Sorting
{
    public class HeapSortTests
    {
        // TODO: Replace this with fsCheck generated data
        private readonly int[] _data = { 2354, 324, 35, 323, 12, -5, 110, 2, 2354, 1, 8, 567 };

        [Fact]
        public void SortAscending_SortsData()
        {
            // Arrange
            var heapSorter = new HeapSorter<int>();

            // Act
            var sortedData = heapSorter.SortAscending(_data);

            // Assert
            Assert.Equal(_data.OrderBy(i => i), sortedData);
        }

        [Fact]
        public void SortDescending_SortsData()
        {
            // Arrange
            var heapSorter = new HeapSorter<int>();

            // Act
            var sortedData = heapSorter.SortDescending(_data);

            // Assert
            Assert.Equal(_data.OrderByDescending(i => i), sortedData);
        }
    }
}