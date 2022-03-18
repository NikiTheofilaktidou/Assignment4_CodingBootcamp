using DesktopApp.SortingAlgorithms;
using System;
using System.Linq;

namespace DesktopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDatabase db = new MyDatabase();
            var shirts = db.TShirts;

            //BubbleSort.OrderBySize(shirts);

            //shirts.BubbleSortOrderBySize();
            //shirts.BubbleSortOrderByDescendingSize();
            //shirts.BubbleSortOrderBySizeColorFabric();
            //shirts.BubbleSortOrderBySizeColorFabric();

            shirts.BubbleSortOrderByDescendingSizeColorFabric();

            //QuickSort.quickSortOrderByColor(shirts,0,shirts.Count-1);
            //akrivws to idio grammh 18 me grammh 16
            shirts.quickSortOrderByColor(0, shirts.Count - 1);


            foreach (var shirt in shirts)
            {
                Console.Write("     "); shirt.Output();
            }
        }
    }
}
