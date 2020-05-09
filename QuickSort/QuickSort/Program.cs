using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 72, 12, 6, 33, 81, 97, 37, 59, 52, 1, 20 };
            int length = array.Length;
            QuickSort quickSort = new QuickSort(array);
            Console.WriteLine("QuickSort");
            quickSort.PrintInitial(array);            
            quickSort.Sort(0, length - 1);
            quickSort.PrintFinal(array);

            Console.ReadKey();
        }
    }
}
