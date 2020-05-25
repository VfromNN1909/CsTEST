using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortsForms
{
    class Sorts
    {
        #region Сортировка слиянием
        //метод для слияния массивов
        public static void Merge(int[] array, int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArray = new int[highIndex - lowIndex + 1];
            var index = 0;
            // разбиваем на подмассивы 
            while ((left <= middleIndex) && (right <= highIndex))
            {
                if (array[left] < array[right])
                {
                    tempArray[index] = array[left];
                    left++;
                }
                else
                {
                    tempArray[index] = array[right];
                    right++;
                }

                index++;
            }
            // сливаем
            for (var i = left; i <= middleIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArray[index] = array[i];
                index++;
            }

            for (var i = 0; i < tempArray.Length; i++)
            {
                array[lowIndex + i] = tempArray[i];
            }
        }

        //сортировка слиянием
        public static int[] MergeSort(int[] array, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                MergeSort(array, lowIndex, middleIndex);
                MergeSort(array, middleIndex + 1, highIndex);
                Merge(array, lowIndex, middleIndex, highIndex);
            }

            return array;
        }
        // итоговая
        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }
        #endregion
        #region Быстрая сортировка
        public static void QuickSort(int[] arr, int first, int last)
        {
            int mid = arr[(last - first) / 2 + first];
            int i = first,
                j = last;
            // сортируем подмассивы
            while (i <= j)
            {
                while (arr[i] < mid && i < last) i++;
                while (arr[j] > mid && j > first) j--;
                if(i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++; j--;
                }
            }
            // сортируем рекусивно
            if (j > first)
                QuickSort(arr, first, j);
            if (i < last)
                QuickSort(arr, i, last);
        }
        public static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        #endregion
    }
}
