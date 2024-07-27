/* using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static void miniMaxSum(List<long> arr)
    {        
        long totalSum = arr.Sum();
        long minimumValue = totalSum - arr.Max();
        long maximumValue = totalSum - arr.Min();

        Console.WriteLine(minimumValue + " " + maximumValue);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        try
        {
            List<long> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();
            Result.miniMaxSum(arr);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}
 */