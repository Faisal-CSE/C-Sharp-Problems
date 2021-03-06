﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithm.Utility;

namespace SortingAlgorithm
{
    class InsertionSort
    {
        public void insertionSort()
        {
            int[] arr = new int[] { 12, 11, 13, 5, 6 };
            int lengthCount = arr.Length;
            for (int i = 1; i < lengthCount; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
            PrintMethod.printArray("Insertion Sort",arr);
            
        }

        public void insertionSortWithList()
        {
            List<int> list = new List<int> { 12, 11, 13, 5, 6 };
            int lengthCount = list.Count;
            for (int i = 1; i < lengthCount; ++i)
            {
                int key = list[i];
                int j = i - 1;

                /* Move elements of arr[0..i-1], that are
                   greater than key, to one position ahead
                   of their current position */
                while (j >= 0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
            PrintMethod.printList("Insertion Sort", list);

        }



        /*
        Theoretical Explanation: 
        12, 11, 13, 5, 6

        Let us loop for i = 1 (second element of the array) to 5 (Size of input array)

        i = 1. Since 11 is smaller than 12, move 12 and insert 11 before 12
        11, 12, 13, 5, 6

        i = 2. 13 will remain at its position as all elements in A[0..I-1] are smaller than 13
        11, 12, 13, 5, 6

        i = 3. 5 will move to the beginning and all other elements from 11 to 13 will move one position ahead of their current position.
        5, 11, 12, 13, 6

        i = 4. 6 will move to position after 5, and elements from 11 to 13 will move one position ahead of their current position.
        5, 6, 11, 12, 13
         
         
         */
    }
}
