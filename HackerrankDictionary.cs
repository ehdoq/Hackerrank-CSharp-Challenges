using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        int n = Int32.Parse(Console.ReadLine());
        Dictionary<string, string> telefonDefteri = new Dictionary<string, string>();

        for (int i = 0; i < n; i++) 
        {
            string[] isimVeTelefon = Console.ReadLine().Split(' ');
            telefonDefteri.Add(isimVeTelefon[0], isimVeTelefon[1]);
        }

        string isim;
        while((isim = Console.ReadLine()) != null) 
        {
            if(telefonDefteri.ContainsKey(isim)) 
            {
                Console.WriteLine(isim + "=" + telefonDefteri[isim]);
            }
            else 
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
