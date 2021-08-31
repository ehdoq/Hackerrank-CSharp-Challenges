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
     * Complete the 'compareTriplets' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY a
     *  2. INTEGER_ARRAY b
     */

    public static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int[] aliceSayi = new int[3];
        int[] bobSayi = new int[3];
        List<int> liste = new List<int>();
        int alice = 0, bob = 0;
        
        for(int i = 0;i < 3;i++)
        {
            aliceSayi[i] = a[i];
        }
        
        for(int i = 0;i < 3;i++)
        {
            bobSayi[i] = b[i];
        }
        
        for(int i = 0;i < 3;i++)
        {
            if(aliceSayi[i]>bobSayi[i])
            {
                alice++;
            }    
            else if(aliceSayi[i]<bobSayi[i])
            {
                bob++;
            }    
        }
        
        liste.Add(alice);
        liste.Add(bob);
        
        return liste;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = Result.compareTriplets(a, b);

        textWriter.WriteLine(String.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
