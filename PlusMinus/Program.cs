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
     public static void plusMinus(List<int> arr, int n)
    {
        int positiveValues = 0;
        int negativeValues = 0;
        int zeros = 0;
        double proportionOfPositiveValues;
        double proportionOfNegativeValues;
        double proportionOfZeros;
        
        foreach (int element in arr)
        {
            if (element > 0)
            {
                positiveValues += 1;
            }               
            else if (element == 0)
            {
                 zeros += 1;
            }   
            else 
            {
                negativeValues += 1;
            }
                               
        }
        
        proportionOfPositiveValues = (double) positiveValues / n;
        proportionOfNegativeValues = (double) negativeValues / n;
        proportionOfZeros = (double) zeros / n;

        Console.WriteLine(proportionOfPositiveValues);
        Console.WriteLine(proportionOfNegativeValues);
        Console.WriteLine(proportionOfZeros);      
        
    }

}

class PlusMinus
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr, n);
    }
}

