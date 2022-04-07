using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Searching_Algorirhm
{
    class Program
    {
        static void Main(string[] args)
        {
            // test for Binary_Search mecthod

            List<int> arr = new List<int> { 1, 7, 8, 2, 3, 0 };
            arr.Sort();
            if (Binary_Search(arr, 5))
                WriteLine("Found!");
            else
                WriteLine("Not Found!");

            // test for linear search

            if (Linear_Search(arr, 7))
                WriteLine("Found");
            else WriteLine("Not Found");
                   
            // test for lower_bound Method
            List<int> list = new List<int> { 1, 2, 3, 5, 5, 6 };
            int length = list.Count();
            int res = lower_bound(0, length - 1, 4, list); // index for first value that more than 4 becuase 4 not found in list
            int res2 = lower_bound(0, length - 1, 5, list); // index for the first element equal 5 ..... first 5 in third index
            WriteLine(res);
            WriteLine(res2);

 
            Console.ReadKey();
        }

        public static bool Linear_Search(List<int> arr,int val)
        {
            //O(n)
            for (int i = 0; i < arr.Count - 1; i++)
            {
                if(arr[i] == val)
                {
                    return true;
                    //break;
                }
            }
            return false;
        }
        public static bool Binary_Search(List<int> arr , int target)
        {
            //O(log(n))
            int start = 0;
            int end = arr.Count - 1;
            int mid;
            while (start <= end)
            {
                mid = (start + end) / 2;
                if (target > arr[mid])
                {
                    start = mid + 1;
                }
                else if (target < arr[mid])
                {
                    end = mid - 1;
                }
                else  return true;
            }
            return false;
        }
        public static int lower_bound(int left, int right, int value, List<int> arr)
        {
            //O(log(n))
            int ans = right + 1;
            while (left <= right) 
            {
                int mid = (left + right) / 2;
                if (arr[mid] >= value)
                {
                    ans = mid;
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
