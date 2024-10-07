using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //q1
            int[] arr = { 15, 5,10 ,1};
            int length=arr.Length;
            for (int i = 0; i < length - 1; i++) {
            for (int j = 0; j < length - i - 1; j++)
                {
                  if  (arr[j] > arr[j + 1])
                    {
                        int array = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = array;

                    }
                }
                    }
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            //q2

            int[] arr1 = { 15,5,10,1};
            int length2=arr1.Length;
            for (int i = 0; i < length2; i++) {
                int minmumIndex = i;
                for (int j = i+1; j < length2; j++) {
                    if (arr1[j ]< arr1[minmumIndex]){
                        minmumIndex = j;

                    } 
                
                }
                int tem=arr1[minmumIndex];
                arr1[minmumIndex] = arr1[i];
                arr1[i] = tem;
                    
                    }
            foreach (int items in arr1) {
                Console.WriteLine(items);
            }
            //q5
            int[] arr2 = { 1, 13, 15,20,22 };
           // int length3 = arr2.Length;
            int c = 1;
            int index = -5;
            int low = 0;
            int high = length - 1;
            while (low <= high) {
                int mid = (low + high) / 2;
                if (arr2[mid] == c)
                {

                    index = mid;
                }
                if (arr2[mid] < c)
                {
                    low = mid + 1;

                }
                else {
                    high = mid - 1;
                }
                
           
                   
                
            }
            Console.WriteLine(index);
            //q4
            int[] arr3 = { 1, 4, 6, 8 };
            int length3=arr3.Length;
            int x = 6;
            int index1 = -4;
            for (int i = 0; i < length3; i++)
            {
                if (arr3[i] == x)
                {
                    index1 = i;
                }

               
                else { Console.WriteLine(index1); }
            }


            Console.ReadLine();
        }
    }
}
