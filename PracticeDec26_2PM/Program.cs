using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec26_2PM
{
    public class Program
    {
        void Bsort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        void SelectSort(int[] arr)
        { //find the lenght
            int n = arr.Length;
            //one by one move position of unsorted array
            for (int i = 0; i < n - 1; i++)
            {
                // find the minimum element in the unsorted array
                int ind_min = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[ind_min])
                    {
                        ind_min = j;
                        // swap the minimum element with the first element in array
                        int temp = arr[ind_min];
                        arr[ind_min] = arr[i];
                        arr[i] = temp;
                        // Console.Write(arr[i]+" ");
                    }
                }
            }
        }

        void Isort()
        {
            int[] arr = new int[5] { 9, 8, 7, 6, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("i=" + i);
                int key = arr[i];
                Console.WriteLine("key=" + key);
                int j = i - 1;
                Console.WriteLine("j=" + j);
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                Console.WriteLine("jU=" + j);
                arr[j + 1] = key;
                for (int h = 0; h < arr.Length; h++)
                {
                    Console.Write(arr[h]);
                }
                Console.WriteLine("---------------------");
            }



        }
        void PrintMethod(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void call()
        {
            Program x = new Program();
            Console.WriteLine("Enter length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements Before sorting\n");
            x.PrintMethod(arr);
            Console.WriteLine("Elements after sorting\n");
            x.Bsort(arr);
            x.PrintMethod(arr);
        }
        static void call2()
        {
            Program x = new Program();
            Console.WriteLine("Enter length of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Elements Before sorting\n");
            x.PrintMethod(arr);
            Console.WriteLine("Elements after sorting\n");
            x.SelectSort(arr);
            x.PrintMethod(arr);
        }
        //static void call1()
        //{
        //    Program x = new Program();
        //    Console.WriteLine("Enter length of array");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    int[] arr = new int[n];
        //    Console.WriteLine("Enter Elements");
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        arr[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Console.WriteLine("Elements Before sorting\n");
        //    x.PrintMethod(arr);
        //    Console.WriteLine("Elements after sorting\n");
        //    x.Isort(arr);
        //    x.PrintMethod(arr);
        //}

        static void Main(string[] args)
        {
            
        }
    }
}
