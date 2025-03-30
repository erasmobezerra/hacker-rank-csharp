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

    /*
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

   public static int minimumNumber(int n, string password)
    {
        const string numbers = "0123456789";
        const string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        const string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string specialCharacters = "!@#$%^&*()-+";
        var minimumNumber = 0;
        
        VerificarCriterio(password, n, ref minimumNumber, numbers);
        VerificarCriterio(password, n, ref minimumNumber, lowerCase);
        VerificarCriterio(password, n, ref minimumNumber, upperCase);
        VerificarCriterio(password, n, ref minimumNumber, specialCharacters);
        
        if (6 - n >= minimumNumber)
            minimumNumber = 6 - n;
    
        return minimumNumber;
    }

    private static void VerificarCriterio(string password, int n, ref int minimumNumber, string constantes)
    {
        var count = 0;
        foreach (var letter in password)
        {
            if (!constantes.Contains(letter))
                count++;
            else
                break;
        }
        if (count == n)
        {
            minimumNumber++;
        }
        
    }



}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string password = Console.ReadLine();

        int answer = Result.minimumNumber(n, password);
        
        Console.WriteLine(answer);

        // textWriter.WriteLine(answer);

        // textWriter.Flush();
        // textWriter.Close();
    }
}