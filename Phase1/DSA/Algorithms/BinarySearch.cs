using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    //T(n)=> O(log n) 
    static class BinarySearch
    {
        static int[] array = { 4, 7, 29, 30, 43, 89, 231, 645, 982 };

        public static void Do()

        {
            int result;
            result = binarysearch(array, 0, array.Length - 1, 645);
            Console.WriteLine("Element at index" + result);
            result = binarysearch(array, 0, array.Length - 1, 648);
            Console.WriteLine("Element at index" + result);

        }

        public static int binarysearch(int[] array, int left, int right, int num)
        {
            if (right >= left)
            {
                //step 1 find mid element 
                int mid = (right + left) / 2;

                //step 2 : check if mid is the  element/num
                if (array[mid] == num)
                {
                    return mid;
                }

                //step 3 : check if num is less than mid 
                if (num < array[mid])
                {
                    return binarysearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarysearch(array, mid + 1, right, num);
                }
            }
            return -1;
        }
    }
}
