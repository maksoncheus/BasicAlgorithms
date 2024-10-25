using BasicAlgorithms.Library.Search;
namespace BasicAlgorithms.Client
{
    internal class Program
    {
        static void Main()
        {
            int[] array = [1,2,3,4,5,7,8,9,11,23,4516,161,23];
            int valueToFind1 = 4;
            int valueToFind2 = -200;
            Console.WriteLine(array.LinearSearch(valueToFind1));
            Console.WriteLine(array.LinearSearch(valueToFind2));

            Console.WriteLine(array.BinarySearch(valueToFind1));
            Console.WriteLine(array.BinarySearch(valueToFind2));
        }
    }
}
