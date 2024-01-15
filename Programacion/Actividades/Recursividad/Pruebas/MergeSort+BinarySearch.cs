using System;
using System.Collections.Generic;
namespace MergeSort
{
    public class Program
    {
        public static void Fusio(int[] array, int left, int m, int right)
        {
            int n = right - left + 1;
            int[] aux = new int[n];
            int k = 0;
            int i = left;
            int j = m + 1;
            while (i <= m && j <= right)
            {
                if (array[i] < array[j]) { aux[k] = array[i]; ++i; }
                else { aux[k] = array[j]; ++j; }
                ++k;
            }
            while (i <= m) { aux[k] = array[i]; ++i; ++k; }
            while (j <= right) { aux[k] = array[j]; ++j; ++k; }
            for (k = 0; k < n; ++k) array[left + k] = aux[k];
        }

        public static void OrdenacioFusio(int[] array, int left, int right)
        {
            if (left < right)
            {
                int m = (left + right) / 2;
                OrdenacioFusio(array, left, m);
                OrdenacioFusio(array, m + 1, right);
                Fusio(array, left, m, right);
            }
        }

        public static int[] InserirInput(int[] array, int maxLength)
        {
            const string NumImput = "Introduce un número";
            int num = 0;

            for (int i = 0; i < maxLength; ++i)
            {
                Console.WriteLine(NumImput);
                num = Convert.ToInt32(Console.ReadLine());
                array[i] = num;
            }
            return array;
        }
        public static int BinarySearch(int[] arr, int first, int last, int searched)
        {
            if (last >= first)
            {
                int mid = first + (last - first) / 2;
                if (arr[mid] == searched)
                {
                    return mid;
                }
                if (arr[mid] > searched)
                {
                    return BinarySearch(arr, first, mid - 1, searched);
                }
                else
                {
                    return BinarySearch(arr, mid + 1, last, searched);
                }
            }
            return -1;
        }

        public static void Main()
        {
            const string MaxInput= "Introduce la cantidad de números vas a poner";
            const string SearchedInput = "Introduce que número buscar";
            const string MsgKeyFound = "L'element es troba a la posició: {0}";
            const string MsgKeyNotFound = "L'element no s'ha trobat.";

            int maxLength = 0, searched = 0;

            Console.WriteLine(MaxInput);
            maxLength = Convert.ToInt32(Console.ReadLine());
            int[] array = new int [maxLength]; 

            array = InserirInput(array, maxLength);
            OrdenacioFusio(array, 0, array.Length - 1);

            Console.WriteLine(SearchedInput);
            searched = Convert.ToInt32(Console.ReadLine());

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int result = BinarySearch(array, 0, array.Length -1, searched);
            Console.WriteLine(result == -1 ? MsgKeyNotFound : MsgKeyFound, result +1);
        }
    }
}