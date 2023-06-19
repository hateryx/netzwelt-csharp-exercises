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


// Console.WriteLine(isElementPresent(1, A_test_1)); // true
// Console.WriteLine(isElementPresent(-1, A_test_1)); // false
// Console.WriteLine(isElementPresent(2000, A_test_2)); // false



// Write a function that returns the elements on odd positions in a list.

static List<int> OddList(List<int> arr)
{

    List<int> odd_list = new List<int>();

    int i = 0;
    while (i < arr.Count)
    {
        if (i % 2 == 1)
        {
            odd_list.Add(arr[i]);
        }
        i++;
    }

    return odd_list;
}

List<int> C_test_1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
List<int> C_test_2 = new List<int> { 11, 13, 15, 17, 19 };
List<int> C_test_3 = new List<int> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };


List<int> odd_list_test_1 = OddList(C_test_1);
List<int> odd_list_test_2 = OddList(C_test_2);
List<int> odd_list_test_3 = OddList(C_test_3);

// Console.WriteLine(string.Join(", ", odd_list_test_1)); // should be: 2, 4, 6, 8, 11
// Console.WriteLine(string.Join(", ", odd_list_test_2)); // should be: 13, 17
// Console.WriteLine(string.Join(", ", odd_list_test_3)); // should be: -4, -2, 0, 2, 4


// E.  Write a function that computes the running total of a list.

static int RunningTotal(List<int> arr)
{
    int total_sum_so_far = 0;

    int i = 0;
    while (i < arr.Count)
    {
        total_sum_so_far += arr[i];
        i++;
    }

    return total_sum_so_far;
}

List<int> E_test_1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
List<int> E_test_2 = new List<int> { -1, -2, -3, -4, -5 };
List<int> E_test_3 = new List<int> { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

// Console.WriteLine(RunningTotal(E_test_1));
// Console.WriteLine(RunningTotal(E_test_2));
// Console.WriteLine(RunningTotal(E_test_3));




// F.  Write three functions that compute the sum of the numbers in a list: using a for-loop, a while-loop and recursion.
// (Subject to availability of these constructs in your language of choice.)


// using for-loop

static int SumViaForLoop(List<int> arr)
{
    int total_sum_so_far = 0;

    for (int i = 0; i < arr.Count; i++)
    {
        total_sum_so_far += arr[i];
    }

    return total_sum_so_far;
}

// Console.WriteLine(SumViaForLoop(E_test_1));
// Console.WriteLine(SumViaForLoop(E_test_2));
// Console.WriteLine(SumViaForLoop(E_test_3));

// using while-loop

static int SumViaWhileLoop(List<int> arr)
{
    int total_sum_so_far = 0;

    int i = 0;
    while (i < arr.Count)
    {
        total_sum_so_far += arr[i];
        i++;
    }

    return total_sum_so_far;
}

// Console.WriteLine(SumViaWhileLoop(E_test_1));
// Console.WriteLine(SumViaWhileLoop(E_test_2));
// Console.WriteLine(SumViaWhileLoop(E_test_3));


// using recursion

static int SumViaRecursion(List<int> arr)
{
    if (arr.Count == 0)
    {
        return 0;
    }

    int currentNumToSum = arr[0];

    List<int> remainingListToSum = arr.GetRange(1, arr.Count - 1);
    int remainingSum = SumViaRecursion(remainingListToSum);

    return currentNumToSum + remainingSum;
}


// Console.WriteLine(SumViaRecursion(E_test_1));
// Console.WriteLine(SumViaRecursion(E_test_2));
// Console.WriteLine(SumViaRecursion(E_test_3));


// G. Write a function on_all that applies a function to every element of a list. Use it to print the first twenty perfect squares. The perfect squares can be found by multiplying each natural number with itself. The first few perfect squares are 1*1= 1, 2*2=4, 3*3=9, 4*4=16. Twelve for example is not a perfect square because there is no natural number m so that m*m=12. 
// (This question is tricky if your programming language makes it difficult to pass functions as arguments.)


// H. Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]

static List<Object> ConcatenateTwoLists(List<string> first_arr, List<int> second_arr)
{
    List<object> concatenated_list = new List<Object>();

    foreach (string item in first_arr)
    {
        concatenated_list.Add(item);
    }

    foreach (int item in second_arr)
    {
        concatenated_list.Add(item);
    }

    return concatenated_list;
}


List<string> H_test_1_input_1 = "Hello".Select(chr => chr.ToString()).ToList();
List<string> H_test_2_input_1 = "ABC".Select(chr => chr.ToString()).ToList();
List<string> H_test_3_input_1 = "aaaa".Select(chr => chr.ToString()).ToList();

List<int> H_test_1_input_2 = new List<int> { 100, 20, 31 };
List<int> H_test_2_input_2 = new List<int> { 1, 2, 3 };
List<int> H_test_3_input_2 = new List<int> { -1 };

List<Object> H_test_case_result_1 = ConcatenateTwoLists(H_test_1_input_1, H_test_1_input_2);
List<Object> H_test_case_result_2 = ConcatenateTwoLists(H_test_2_input_1, H_test_2_input_2);
List<Object> H_test_case_result_3 = ConcatenateTwoLists(H_test_3_input_1, H_test_3_input_2);


// Console.WriteLine(string.Join(", ", H_test_case_result_1)); // should be: H, e, l, l, o, 100, 20, 31
// Console.WriteLine(string.Join(", ", H_test_case_result_2)); // should be: A, B, C, 100, 20, 31
// Console.WriteLine(string.Join(", ", H_test_case_result_3)); // should be: -4, -2, 0, 2, 4


// I. Write a function that combines two lists by alternately taking elements, e.g. [a,b,c], [1,2,3] → [a,1,b,2,c,3].

static List<object> AlternatingCombination(List<string> first_arr, List<int> second_arr)
{
    List<object> answer = new List<object>();

    int n = first_arr.Count + second_arr.Count;

    int tracker_1 = 0;
    int tracker_2 = 0;

    int i = 0;
    while (i < n)
    {
        if (i % 2 == 0)
        {
            if (tracker_1 < first_arr.Count)
            {
                answer.Add(first_arr[tracker_1]);
                tracker_1++;
            }

        }
        else
        {
            if (tracker_2 < second_arr.Count)
            {
                answer.Add(second_arr[tracker_2]);
                tracker_2++;
            }
        }
        i++;
    }

    while (tracker_1 < first_arr.Count)
    {
        answer.Add(first_arr[tracker_1]);
        tracker_1++;
    }

    while (tracker_2 < second_arr.Count)
    {
        answer.Add(second_arr[tracker_2]);
        tracker_2++;
    }

    return answer;
}

List<string> I_test_1_input_1 = "Hello".Select(chr => chr.ToString()).ToList();
List<string> I_test_2_input_1 = "ABC".Select(chr => chr.ToString()).ToList();
List<string> I_test_3_input_1 = "aaaaaa".Select(chr => chr.ToString()).ToList();

List<int> I_test_1_input_2 = new List<int> { 100, 20, 31, 45, 65, 77 };
List<int> I_test_2_input_2 = new List<int> { 1, 2, 3 };
List<int> I_test_3_input_2 = new List<int> { -1 };


List<Object> I_test_case_result_1 = AlternatingCombination(I_test_1_input_1, I_test_1_input_2);
List<Object> I_test_case_result_2 = AlternatingCombination(I_test_2_input_1, I_test_2_input_2);
List<Object> I_test_case_result_3 = AlternatingCombination(I_test_3_input_1, I_test_3_input_2);


// Console.WriteLine(string.Join(", ", I_test_case_result_1)); // should be: H, e, l, l, o, 100, 20, 31
// Console.WriteLine(string.Join(", ", I_test_case_result_2)); // should be: A, B, C, 100, 20, 31
// Console.WriteLine(string.Join(", ", I_test_case_result_3)); // should be: -4, -2, 0, 2, 4


// J. Write a function that merges two sorted lists into a new sorted list. [1,4,6],[2,3,5] → [1,2,3,4,5,6]. 
// You can do this quicker than concatenating them followed by a sort.

static List<int> SortedMergedList(List<int> first_arr, List<int> second_arr)
{
    int i = 0;
    while (i < second_arr.Count)
    {
        first_arr.Add(second_arr[i]);
        i++;
    }

    first_arr.Sort();

    return first_arr;
}

List<int> J_test_1_input_1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
List<int> J_test_1_input_2 = new List<int> { 21, 22, 133, 44, 55, 86, 97, 8, 119, 11 };

List<int> J_test_2_input_1 = new List<int> { -121, -21, -331, -34, -35 };
List<int> J_test_2_input_2 = new List<int> { -231, -322, -323, -43, -51 };

List<int> J_test_3_input_1 = new List<int> { -54, -4, -73, -42, -1, 0, 11, 2, 73, 45, 5 };
List<int> J_test_3_input_2 = new List<int> { -55, -64, -38, -62, -1, 0, 14, 62, 34, 4, 635 };

List<int> J_test_case_result_1 = SortedMergedList(J_test_1_input_1, J_test_1_input_2);
List<int> J_test_case_result_2 = SortedMergedList(J_test_2_input_1, J_test_2_input_2);
List<int> J_test_case_result_3 = SortedMergedList(J_test_3_input_1, J_test_3_input_2);


Console.WriteLine(string.Join(", ", J_test_case_result_1)); // should be: H, e, l, l, o, 100, 20, 31
Console.WriteLine(string.Join(", ", J_test_case_result_2)); // should be: A, B, C, 100, 20, 31
Console.WriteLine(string.Join(", ", J_test_case_result_3)); // should be: -4, -2, 0, 2, 4