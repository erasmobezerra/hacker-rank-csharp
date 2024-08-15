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
        public static void staircase(int n)        
        {   
            int x = n;
            for (int i = 0; i < n; i++)
            {   
                x -= 1;
                var space = new String(' ', x);
                var hashtag = new String('#', i+1);
		        Console.WriteLine(space + hashtag);
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            Result.staircase(n);
        }
    }

