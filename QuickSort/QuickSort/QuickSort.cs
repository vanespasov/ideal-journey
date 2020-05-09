using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    // QuickSort is one of the sort alghorithmsh that works on that way that recursively divides the collection of numbers
    // into progressively smaller "partitions" within the collection and sorts those partitions
    // in place and the final result is a fully sorted array.    
    // The steps are:
    // 1. Select a pivot point (implementation below selects the last value).
    // 2. Reorder the collection so that all values less than the pivot are before that pivot, and all values greater than the pivot are after the pivot. After this partitioning, the pivot element is in its final position.
    // 3. Recursively do this partitioning on the "less than pivot" set and the "greater than pivot" set.
    // Continue recursively applying this algorithm until the array is sorted.
    public class QuickSort
    {
        int[] _array;

        public QuickSort(int[] array)
        {
            _array = array;
        }

        #region Private methods
        private int Partition(int[] array, int low, int high)
        {
            //1. Select a pivot point.
            int pivot = array[high];

            int lowIndex = (low - 1);

            //2. Reorder the collection.
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }

        private void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(array, low, high);

                //3. Recursively continue sorting the array
                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }

        private void Print(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length; ++i)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Public methods
        public void Sort(int low, int high)
        {
            Sort(_array, low, high);
        }

        public void PrintInitial(int[] array)
        {
            Console.Write("Initial array is: ");
            Print(array);
        }
        public void PrintFinal(int[] array)
        {
            Console.Write("Sorted array is: ");
            Print(array);
        }
        #endregion
    }
}
