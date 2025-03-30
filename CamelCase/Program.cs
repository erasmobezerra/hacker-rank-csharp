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
     * Complete the 'camelcase' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int camelcase(string text)
    {
        var wordsCount = 1;
        for (var i = 0; i < text.Length; i++)
        {
            if (char.IsUpper(text[i]))
                wordsCount++;
        }

        return wordsCount;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        var s = Console.ReadLine();

        var result = Result.camelcase(s);
        
        Console.WriteLine(result);
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}