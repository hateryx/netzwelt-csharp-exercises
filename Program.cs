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

//Test cases
List<int> A_test_1 = new List<int> { 1, 2, 8, 4, 5 };
List<int> A_test_2 = new List<int> { 100, 2, 8, 99, 5 };
List<int> A_test_3 = new List<int> { -2, -20, -8, -1, -50 };

// Console.WriteLine(LargestElement(A_test_1));
// Console.WriteLine(LargestElement(A_test_2));
// Console.WriteLine(LargestElement(A_test_3));


// Write function that reverses a list, preferably in place.


static List<int> ReverseList(List<int> arr)
{

    List<int> reversed = new List<int>();

    int i = arr.Count - 1;
    while (i >= 0)
    {
        reversed.Add(arr[i]);
        i--;
    }

    return reversed;
}

List<int> reversed_1 = ReverseList(A_test_1);
List<int> reversed_2 = ReverseList(A_test_2);
List<int> reversed_3 = ReverseList(A_test_3);

// Console.WriteLine(string.Join(", ", reversed_1));
// Console.WriteLine(string.Join(", ", reversed_2));
// Console.WriteLine(string.Join(", ", reversed_3));

//Write a function that checks whether an element occurs in a list.

static bool isElementPresent(int target, List<int> arr)
{
    int i = 0;
    while (i < arr.Count)
    {
        if (target == arr[i])
        {
            return true;
        }
        i++;
    }

    return false;
}


Console.WriteLine(isElementPresent(1, A_test_1)); // true
Console.WriteLine(isElementPresent(-1, A_test_1)); // false
Console.WriteLine(isElementPresent(2000, A_test_2)); // false



