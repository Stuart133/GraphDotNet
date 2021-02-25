﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsDotNet.DataStructures.Heaps
{
    /// <summary>
    /// A binary max heap data structure
    /// </summary>
    /// <typeparam name="T">Item stored in heap</typeparam>
    public class MaxHeap<T> : Heap<T>
        where T : IComparable<T>
    {
        public MaxHeap(IEnumerable<T> data)
            : base(MaxHeapComparison)
        {
            _data = data.ToList();
            BuildHeap();
        }

        private static bool MaxHeapComparison(T childItem, T item)
        {
            return childItem.CompareTo(item) > 0;
        }
    }
}
