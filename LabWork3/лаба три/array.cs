using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба_три
{

        class ArraySort
        {
            public ArraySort() //конструктор
            {
            }
            public int[] a;
            private static void swap(ref int x, ref int y)
            {
                int temp = x; x = y; y = temp;
            }
            public void SelectSort(int[] a, ref int sr, ref int obm)
            {
                int max;
                int length = a.Length;
                for (int i = 0; i < length - 1; i++)
                {
                    max = i;
                    for (int j = i + 1; j < length; j++)
                    {
                        sr++;

                        if (a[j] > a[max])
                        {

                            max = j;
                        }
                    }
                    sr++;
                    if (max != i)
                    {
                        swap(ref a[i], ref a[max]);
                        obm++;
                    }
                }
            }
            public void InsertSort(int[] a, ref int sr, ref int obm)
            {
                for (int i = 1; i < a.Length; i++)
                {
                    int cur = a[i];
                    int j = i;
                    while (j > 0 && cur > a[j - 1])
                    {
                        sr++;
                        a[j] = a[j - 1];
                        j--;
                    }
                    a[j] = cur;
                }
                sr++;
            }
            public void BubbleSort(int[] a, ref int sr, ref int obm)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a.Length - i - 1; j++)
                    {
                        sr++;

                        if (a[j] < a[j + 1])
                        {
                            swap(ref a[j], ref a[j + 1]);

                            obm++;
                        }
                    }
                }
            }

            public void insertionSortRecursive(int[] a, int lengthArray, ref int sr, ref int obm)  //Рекурсивная сортировка вставками 
            {
               if (lengthArray <= 1)
               {
                return;
               }
                sr++;
                insertionSortRecursive(a, lengthArray - 1, ref sr, ref obm);
                int last = a[lengthArray - 1];
                int j = lengthArray - 2;
                while (j >= 0 && a[j] > last)
                {
                    a[j + 1] = a[j];
                    j--;
                    obm++;
                }
                a[j + 1] = last;
            }

            public int FindPivot(int[] numbers, int minIndex, int maxIndex,ref int sr,ref int obm)  //Нахождение пивота 
            {
            int pivot = minIndex - 1;
            int temp = 0;
            for (int i = minIndex; i < maxIndex; i++)
            {
                if (numbers[i] < numbers[maxIndex])
                {
                    pivot++;
                    temp = numbers[pivot];
                    numbers[pivot] = numbers[i];
                    numbers[i] = temp;
                    sr++;
                    obm++;
                }
            }
            pivot++;
            temp = numbers[pivot];
            numbers[pivot] = numbers[maxIndex];
            numbers[maxIndex] = temp;
            return pivot;
            }
            
        
        
        
            public int[] QuickSort(int[] numbers, int minIndex, int maxIndex,ref int sr, ref int obm)  //Быстрая сортировака 
            {
            if (minIndex >= maxIndex)
            {
                return numbers;
            }
            int pivot = FindPivot(numbers, minIndex, maxIndex, ref sr, ref obm);
            QuickSort(numbers, minIndex, pivot - 1,ref sr,ref obm);
            QuickSort(numbers, pivot + 1, maxIndex,ref sr, ref obm);
            return numbers;
            
            }






        }

        


}
