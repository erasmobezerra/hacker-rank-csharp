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

class Result
{


    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        List<int> applesDistance = [];
        List<int> orangesDistance = [];
        int applesInTheInclusiveRange = 0;
        int orangesInTheInclusiveRange = 0;

        for (int i = 0; i < apples.Count; i++)
        {
            applesDistance.Add(a + apples[i]);
            
            if (applesDistance[i] >= s && applesDistance[i] <= t)
            {
                applesInTheInclusiveRange += 1;
            }    
        }
        Console.WriteLine(applesInTheInclusiveRange);

        for (int i = 0; i < oranges.Count; i++)
        {
            orangesDistance.Add(b + oranges[i]);    

            if (orangesDistance[i] >= s && orangesDistance[i] <= t)
            {
                orangesInTheInclusiveRange += 1;
            } 
        }
        Console.WriteLine(orangesInTheInclusiveRange);


    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[]? firstMultipleInput = Console.ReadLine()?.TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[]? secondMultipleInput = Console.ReadLine()?.TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[]? thirdMultipleInput = Console.ReadLine()?.TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int>? apples = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int>? oranges = Console.ReadLine()?.TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
