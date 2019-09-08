using System;

namespace Search1
{
    class Program
    {
                static bool SearchArr(int[] arr1, int a)
        {
            int i = 0;
            while ( i < arr1.Length)
            {
                if (arr1[i] == a)
                {
                    return true;
                }

                i++;
            }
                return false;
        }
        static void Main(string[] args)
        {
            int[] arr1 = new int[10] { 14, 5, 12, 5, 65, 65, 13, 2, 5, 6 };
            Array.Sort(arr1);
            int mas = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((Array.Exists(arr1, el => el == mas)));//метод класса Array
            Console.WriteLine(SearchArr(arr1, mas));
            Console.ReadLine();
        }
    }
}
