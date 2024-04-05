using System;
using System.Collections.Generic;

class JumpSearchExample
{
    static int JumpSearch(List<int> arr, int x)
    {
        int n = arr.Count;
        int step = (int)Math.Floor(Math.Sqrt(n));

        int prev = 0;
        while (arr[Math.Min(step, n) - 1] < x)
        {
            prev = step;
            step += (int)Math.Floor(Math.Sqrt(n));
            if (prev >= n)
                return -1;
        }

        while (arr[prev] < x)
        {
            prev++;
            if (prev == Math.Min(step, n))
                return -1;
        }

        if (arr[prev] == x)
            return prev;

        return -1;
    }

    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int x = 13;
        int index = JumpSearch(arr, x);

        if (index != -1)
            Console.WriteLine("Element " + x + " found at index " + index);
        else
            Console.WriteLine("Element " + x + " not found in the array.");
    }
}
