using System;
using System.Collections.Generic;

namespace Koleksiyon_Soru_3
{
    class Program
    {
        //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan 
        //ve dizinin elemanlarını sıralayan programı yazınız.

        static void Main(string[] args)
        {
            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            System.Console.WriteLine("Cümle giriniz: ");
            string cumle = Console.ReadLine();

            List<char> sslHrflr = new List<char>();

            for (int i = 0; i < sesliHarfler.Length; i++)
                {
                    for (int j = 0; j < cumle.Length; j++)
                    {
                        if (cumle[j] == sesliHarfler[i])
                        {
                            sslHrflr.Add(cumle[j]);
                        }
                    }
                }

            foreach (var s in sslHrflr)
            {
                System.Console.Write(s + ", ");
            }
        }
    }
}
