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
        public static T[] BubbleSort<T>(this T[] inputArray) where T : IComparable<T>
        {
            ArgumentNullException.ThrowIfNull(inputArray, nameof(inputArray));
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
        public static T[] SelectionSort<T>(this T[] inputArray) where T : IComparable<T>
        {
            ArgumentNullException.ThrowIfNull(inputArray, nameof(inputArray));
            T[] sortedArray = new T[inputArray.Length];
            for (int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = inputArray[i];
            }
            int n = sortedArray.Length;
            if (n > 0)
            {
                int sortedLength = 0;
                while (sortedLength != n)
                {
                    int minIndex = FindIndexOfMinElementInArray(sortedArray, sortedLength);
                    Swap(ref sortedArray[minIndex], ref sortedArray[sortedLength]);
                    sortedLength++;
                }
            }
            return sortedArray;
        }

        private static int FindIndexOfMinElementInArray<T>(T[] sortedArray, int startIndex) where T : IComparable<T>
        {
            int indexOfMinElement = startIndex;
            for (int i = startIndex; i < sortedArray.Length; i++)
                if (sortedArray[i].CompareTo(sortedArray[indexOfMinElement]) < 0)
                    indexOfMinElement = i;
            return indexOfMinElement;
        }
    }
}
