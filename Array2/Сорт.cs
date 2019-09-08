using System;

namespace Array2
{
    class Program
    {
        static int[] SortArr(int[] arr1)
        {
            int i = 0;
            int temp;//временное значение элемента массива
            bool flag = false;//сигнал того что был обмен местами элементов массива

            while (i < arr1.Length)
            {
                if (i + 1 != arr1.Length && arr1[i] > arr1[i + 1])
                {
                    temp = arr1[i];
                    arr1[i] = arr1[i + 1];
                    arr1[i + 1] = temp;
                    flag = true;
                }
                i++;
                if (i == arr1.Length && flag == true)
                {
                    flag = false;
                    i = 0;
                }
            }
            return (arr1);
        }

        static void Main(string[] args)
        {
            int[] arr1 = new int[10] {14, 5, 12, 5, 65, 65, 13, 2, 5, 6 };
            int[] sortedarr = SortArr(arr1);
            Console.Write(string.Join(", ", sortedarr));
            
            //Стандартный метод Sort класса Array
            //Array.Sort(arr1);           
        }
    }
}
