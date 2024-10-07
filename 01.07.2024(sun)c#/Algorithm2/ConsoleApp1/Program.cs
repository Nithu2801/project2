using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int[] left = new int[arr.Length / 2];
            int[] right = new int[arr.Length - left.Length];

            Array.Copy(arr, 0, left, 0, left.Length);
            Array.Copy(arr, left.Length, right, 0, right.Length);

            MergeSort(left);
            MergeSort(right);
            Merge(left, right, arr);
        }

        private static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }

        public static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Original array:");
            Console.WriteLine(string.Join(" ", arr));

            MergeSort(arr);

            Console.WriteLine("\nSorted array:");
            Console.WriteLine(string.Join(" ", arr));
        }
    
}
}
