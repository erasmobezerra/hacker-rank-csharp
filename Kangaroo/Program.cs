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
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        // Receber os argumentos 
        var kangarooPosition1 = x1;
        var kangarooPosition2 = x2;
        var kangarooJump1 = v1;
        var kangarooJump2 = v2;
        var kangarooMeet = " ";
        
        // Em laço for, somar os valores dos saltos de cada canguru até que os dois coincidam. Limite de dez mil tentativas 
        for (var index = 0; index < 10000; index++)
        {
            if (x1 < kangarooPosition2 && kangarooJump1 < kangarooJump2)
            {
                // Canguru1 nunca poderá alcançar Canguru2 
                kangarooMeet = "NO"; break;
            }
            else
            {
                x1 += kangarooJump1;
                kangarooPosition2 += kangarooJump2;
                kangarooMeet = (kangarooPosition1 == kangarooPosition2) ? "YES" : "NO";
                if (kangarooMeet == "YES") break;
            }
        }
        return kangarooMeet;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);

        int v1 = Convert.ToInt32(firstMultipleInput[1]);

        int x2 = Convert.ToInt32(firstMultipleInput[2]);

        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine(result);
        // textWriter.WriteLine(result);
        //
        // textWriter.Flush();
        // textWriter.Close();
    }
}