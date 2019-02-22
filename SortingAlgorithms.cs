using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        //Bubble sort n(n-1)/2 swaps max.
        static void BubbleSort(int[] arr)
        {
            bool swapped;

            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                swapped = false;
                for (int j = 0; j < length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }

        /*Selection Sort:
         * Finds the smallest element, and swaps it with the element in the first position and so on....
         * Used for smaller lists.
         */
        static void SelectionSort(int[] arr)
        {
            int length = arr.Length;
            for (int k = 0; k < length - 1; k++)
            {
                int min_idx = k;
                for (int j = k + 1; j < length; j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        int temp = arr[min_idx];
                        arr[min_idx] = arr[k];
                        arr[k] = temp;
                    }
                }
            }
        }

        /*Insertion Sort
         * Sort the first two elements, and place the next ones in the appropriate postition.
         * Used for smaller listsm inefficient for large ones.
         */
        static void InsertionSort(int[] arr)
        {
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j = j - 1;
                }
            }
        }

        /*Merge Sort
         * Breaking down large problems into smaller ones, until all items are just 1 item long. Then it puts it back togeather in sort-order.
         */
        static void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }
        static void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            for (int ii = 0; ii < n1; ii++)
            {
                L[ii] = arr[l + ii];
            }
            for (int jj = 0; jj < n2; jj++)
            {
                R[jj] = arr[m + 1 + jj];
            }

            int i = 0;
            int j = 0;
            int k = l;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                i++;
                k++;
            }
        }      
    }
}
