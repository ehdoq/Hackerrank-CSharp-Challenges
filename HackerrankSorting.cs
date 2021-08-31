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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        int gecici, sayac = 0, ilk = 0, son = 0;

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        for (int i = 0; i <= a.Count - 1; i++)
        {
            for (int j = 1; j <= a.Count - 1; j++)
            {
                ilk = a[0];
                son = a[a.Count - 1];
                if (a[j - 1] > a[j])
                {
                    gecici = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = gecici;
                    sayac++;
                }
            }
            
            if(sayac == 0)
            {
                break;
            }
        }
        
        Console.WriteLine("Array is sorted in " + sayac + " swaps.");
        Console.WriteLine("First Element: " + ilk);
        Console.WriteLine("Last Element: " + son);
    }
}

