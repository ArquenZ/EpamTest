using System;

namespace Array2
{
    class Program
    {
        static int[] SortArr(int[] arr1)
        {
            int i = 0;
            int temp;//временное значение элемента массива
           

            while (i < arr1.Length-1)
            {
                if ( arr1[i] > arr1[i + 1])
                {
                    temp = arr1[i];
                    arr1[i] = arr1[i + 1];
                    arr1[i + 1] = temp;                    
                    i = 0;
                    continue;
                }
                i++;                
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
