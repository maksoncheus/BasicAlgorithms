using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAlgorithms.Library.Sorting
{
    public static class SortingExtensionMethods
    {
        /// <summary>
        /// Swap two elements among themselves
        /// </summary>
        /// <typeparam name="T">Type of arguments</typeparam>
        /// <param name="left">Left argument to replace</param>
        /// <param name="right">Right argument to replace</param>
        private static void Swap<T>(ref T left, ref T right) => (right, left) = (left, right);
        /// <summary>
        /// Easiest algorithm to sort Array
        /// </summary>
        /// <typeparam name="T">Type of elements in Array</typeparam>
        /// <param name="inputArray">Array to sort</param>
        /// <returns>Sorted array</returns>
        public static T[] BubbleSort<T>(T[] inputArray) where T : IComparable<T>
        {
            T[] sortedArray = new T[inputArray.Length];
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = inputArray[i];
            }
            int n = sortedArray.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (sortedArray[j].CompareTo(sortedArray[j + 1]) > 0)
                        Swap(ref sortedArray[j], ref sortedArray[j + 1]);
            return sortedArray;
        }
    }
}
