using System;
using System.Collections.Generic;

class JumpSearchExample
{
    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int x = 13;
        int index = -1;

        if (index != -1)
            Console.WriteLine("Element " + x + " found at index " + index);
        else
            Console.WriteLine("Element " + x + " not found in the array.");
    }
}