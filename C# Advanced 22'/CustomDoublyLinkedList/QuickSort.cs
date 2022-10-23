using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class QuickSort
    {
        private int pivot;

        public int Partition(int[] arr, int left, int right)
        {
            pivot = arr[left];

            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    int tempNum = arr[right];
                    arr[right] = arr[left];
                    arr[left] = tempNum;
                }
                else
                {
                    return right;
                }
            }
        }
        public void QuickSortMethod(int[] arr, int left, int right)
        {
            if (left < right)
            {
                pivot = Partition(arr, left, right);
            }

            if (pivot > 1)
            {
                QuickSortMethod(arr, left, pivot - 1);
            }

            if (pivot + 1 < right)
            {
                QuickSortMethod(arr, pivot + 1, right);
            }
        }

    }
}
