using BasicAlgorithms.Library.Sorting;

namespace BasicAlgorithms.Library.Search
{
    public static class SearchExtensionMethods
    {
        /// <summary>
        /// Linear search in array
        /// </summary>
        /// <typeparam name="T">Type of elements in array, returned value</typeparam>
        /// <param name="array">Array where the search is performed</param>
        /// <param name="value">Value to find</param>
        /// <returns>Index of element in array. -1 if element is not found</returns>
        public static int LinearSearch<T>(this T[] array, T value)
        {
            ArgumentNullException.ThrowIfNull(array, nameof(array));
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]?.Equals(value) ?? false)
                    return i;
            }
            return -1;
        }
        /// <summary>
        /// Binary search in array
        /// </summary>
        /// <typeparam name="T">Type of elements in array, returned value</typeparam>
        /// <param name="array">Array where the search is performed</param>
        /// <param name="value">Value to find</param>
        /// <returns>Index of element in array. -1 if element is not found</returns>
        /// Works only on sorted arrays
        public static int BinarySearch<T>(this T[] array, T value) where T : IComparable<T>
        {
            ArgumentNullException.ThrowIfNull(array, nameof(array));
            array = array.BubbleSort();
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle].CompareTo(value) == 0)
                    return middle;

                if(array[middle].CompareTo(value) < 0)
                    left = middle + 1;

                if(array[middle].CompareTo(value) > 0)
                    right = middle -1;
            }
            return -1;
        }
    }
}
