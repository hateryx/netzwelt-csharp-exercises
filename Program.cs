using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

// static bool IsPalindrome(int input)
// {
//     int original = input;
//     int reversed = 0;

//     while (original > 0)
//     {
//         // 12321
//         // 1232
//         int mod = original % 10;
//         reversed = reversed * 10;
//         reversed += mod;
//         original = original / 10;
//     }

//     return input == reversed;
// }

// Console.WriteLine(IsPalindrome(123)); // false
// Console.WriteLine(IsPalindrome(12321)); // true
// Console.WriteLine(IsPalindrome(9987899)); // true
// Console.WriteLine(IsPalindrome(9987999)); // false



//Write a function that returns the largest element in a list.

static int LargestElement(List<int> arr)
{
    int largest = arr[0];

    int i = 1;
    while (i < arr.Count)
    {
        if (largest < arr[i])
        {
            largest = arr[i];
        }
        i++;
    }

    return largest;
}

List<int> A_test_1 = new List<int> { 1, 2, 8, 4, 5 };
List<int> A_test_2 = new List<int> { 100, 2, 8, 99, 5 };
List<int> A_test_3 = new List<int> { -2, -20, -8, -1, -50 };

Console.WriteLine(LargestElement(A_test_1));
Console.WriteLine(LargestElement(A_test_2));
Console.WriteLine(LargestElement(A_test_3));


