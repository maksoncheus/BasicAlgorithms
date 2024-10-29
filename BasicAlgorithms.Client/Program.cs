using BasicAlgorithms.Library.Search;
using BasicAlgorithms.Library.Sorting;
using System.Diagnostics;
namespace BasicAlgorithms.Client
{
    internal class Program
    {
        private static void Main()
        {
            int[] array = new int[10];
            Stopwatch sw = new Stopwatch();
            Random random = new Random();
            for(int i = 0; i < array.Length; i++)
                array[i] = random.Next(100);
            Console.WriteLine(string.Join(',', array));
            sw.Start();
            Console.WriteLine(string.Join(',', array.SelectionSort()));
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
