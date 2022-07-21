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
    public static void StairCase(int n)
    {
        int bosluk = n, kare = 0;
        for(int i = 0; i < n; i++)
        {
            bosluk = n - (i + 1);
            for(int j = 0; j < bosluk; j++)
            {
                Console.Write(" ");
            } 
            
            kare = i + 1; 
            for(int k = 0; k < kare; k++)
            {
                Console.Write("#");
            } 
            Console.WriteLine();
        }
    }
 
    public static void StairCase2(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new String(' ', n - i) + new String('#', i));
        }
    }
    
    public static void StairCase3(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            var bosluk = new String(' ', n - i);
            var kare = new String('#', i);
            Console.WriteLine(bosluk + kare);
        }
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.StairCase(n);
    }
}
