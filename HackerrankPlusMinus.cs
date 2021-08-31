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
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    
    public static void plusMinus(List<int> arr)
    {
        double arti = 0, eksi = 0, sifir = 0, sayac = arr.Count ;
        for(int i = 0; i < sayac;i++)
        {
            if(arr[i] > 0)
            {
                arti++;
            }
            else if(arr[i] < 0)
            {
                eksi++;
            }
            else if(arr[i] == 0)
            {
                sifir++;
            }
        }
        
        Console.WriteLine((double)(arti / sayac));
        Console.WriteLine((double)(eksi / sayac));
        Console.WriteLine((double)(sifir / sayac));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
