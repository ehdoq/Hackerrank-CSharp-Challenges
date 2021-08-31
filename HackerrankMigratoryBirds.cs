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
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int[] kusTipSayisi = new int[5];
        
        for (int i = 0; i < arr.Count; i++)
        {
            kusTipSayisi[arr[i] - 1]++;
        }

        int maksimumKusTipSayisi = kusTipSayisi[0];
        int maksimumKusTipi = 1;

        for (int i = 1; i < 5; i++)
        {
            if (kusTipSayisi[i] > maksimumKusTipSayisi)
            {
                maksimumKusTipSayisi = kusTipSayisi[i];
                maksimumKusTipi = i + 1;
            }

            if (kusTipSayisi[i] == maksimumKusTipSayisi && i + 1 < maksimumKusTipi)
                maksimumKusTipi = i + 1;
        }

        return maksimumKusTipi;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
