using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; ++i)
        {
            string yazi = Console.ReadLine();
            string cift = "";
            string tek = "";
            
            for (int j = 0; j < yazi.Length - 1; j += 2)
            {
                cift += yazi[j];
                tek += yazi[j + 1];
            }

            if (yazi.Length % 2 != 0)
            {
                cift += yazi[yazi.Length - 1];    
            }
            
            Console.WriteLine("{0} {1}", cift, tek);
        }
    }
}
