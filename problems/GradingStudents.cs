/* using System.CodeDom.Compiler;
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



    public static List<int> gradingStudents(List<int> grades)
    {
        List<int> students = [];
        int roundUpToNextMultipleOfFive;
        foreach(int grade in grades)
        {
            roundUpToNextMultipleOfFive = (int)Math.Ceiling(grade / 5.0) * 5;
            if (grade < 38 || roundUpToNextMultipleOfFive - grade >= 3)
            {
                students.Add(grade);
            }
            else if (roundUpToNextMultipleOfFive - grade < 3) 
            {
                students.Add(roundUpToNextMultipleOfFive);
            }
     
        }
        return students;
    }
    

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int gradesCount = Convert.ToInt32(Console.ReadLine()?.Trim());

        List<int> grades = new List<int>();

        for (int i = 0; i < gradesCount; i++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine()?.Trim());
            grades.Add(gradesItem);
        }

        List<int> result = Result.gradingStudents(grades);

        Console.WriteLine(String.Join("\n", result));
    //    textWriter.WriteLine(String.Join("\n", result));

    //    textWriter.Flush();
    //    textWriter.Close(); 
    }
}
 */