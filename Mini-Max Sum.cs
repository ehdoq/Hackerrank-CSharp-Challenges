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
    public static void miniMaxSum(List<int> arr)
    {
        long min = 0, max = 0;
        bool ilkDongu = true;

        for (int i = 0; i < arr.Count; i++)
        {
            long sayac = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (i != j)
                {
                    sayac += arr[j];
                }
            }

            if (ilkDongu)
            {
                min = sayac;
                max = sayac;
                ilkDongu = false;
            }
            else
            {               
                if (sayac < min)
                {
                    min = sayac;

                }
                else if (sayac > max)
                {
                    max = sayac;
                }
            }
        }
        Console.WriteLine($"{min} {max}");
    }
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
