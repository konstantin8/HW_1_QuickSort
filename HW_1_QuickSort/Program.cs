using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, last, first = 0;

            Console.WriteLine("Specify the dimensions of the array that you want to create: ");
            size = Convert.ToInt32(Console.ReadLine());
            last = size - 1;
            int[] arr = new int[size];

            FillArrayRandomNumbers(arr, size);

            Console.WriteLine("\n------------------------------------------------------------");

            ResultOfQuickSort(arr, first, last, size);

        }

        static void QuickSort (int[] arr, int first, int last)
        {
            int mid = arr[first + (last - first) / 2]; // = (first+last)/2
            int temp, fst = first, lst = last;
    
            while (fst <= lst)
            {
                while (arr[fst] < mid)
                {
                    fst++;
                }
                while (arr[lst] > mid)
                {
                    lst--;
                }
                if (fst <= lst)
                {
                    temp = arr[fst];
                    arr[fst] = arr[lst];
                    arr[lst] = temp;
                    fst++;
                    lst--;
                }
                else { }
            }
            RecursiveSort(fst, lst, first, last, arr);
        }

        static void RecursiveSort (int fst, int lst, int first, int last, int[] arr)
        {
            if (fst < last)
            {
                QuickSort(arr, fst, last);
            }
            else { }

            if (first < lst)
            {
                QuickSort(arr, first, lst);
            }
            else { }
        }

        static void FillArrayRandomNumbers (int[] arr, int size)
        {
            Random rnd = new Random();
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = rnd.Next(1, 10);
            }

            Console.WriteLine("The array was successfully created: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void ResultOfQuickSort (int [] arr, int first, int last, int size)
        {
            QuickSort(arr, first, last);

            Console.WriteLine("Your array was sorted!");
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n");
        }
    }
}
