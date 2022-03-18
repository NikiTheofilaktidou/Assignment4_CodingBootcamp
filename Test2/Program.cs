using System;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] p = { 1, 1, 3, 4, 4, 8, 9 };

            Array.Sort(p);
            int index = Array.BinarySearch(p, -10);

            Console.WriteLine(index);
        }
    }
}
