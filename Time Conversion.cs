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
    public static string timeConversion(string s)
    {
        var am_Mi_Pm_Mi = s.Substring(8);
        var saat = s.Substring(0, 2);
        var dakikaVeSaniye = s.Substring(2, 6);
        if (am_Mi_Pm_Mi == "AM" && saat == "12")
        {
            saat = "00";
        }
        else if (am_Mi_Pm_Mi == "PM")
        {
            var saatDonustur = int.Parse(saat);
            if (saatDonustur != 12)
            {
                saat = Convert.ToString(12 + saatDonustur);
            }
        }
        return (saat + dakikaVeSaniye);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
