using System;

namespace Data_Structures_And_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures and Algorithms Practice Problems!");
            Console.WriteLine("Program of Bubble Sort to sort the array!");
            int[] arr;
            Console.WriteLine("Enter array size:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements: ", n);
            arr = new int[n];
            for (int i = 0;i < n; ++i)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort s = new BubbleSort();
            s.Sort(arr);
            s.Display(arr);
        }
    }
}