using System;

namespace Ders06AlgoritmaSorusuUc
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi_N = 0, sayac = 0;

            System.Console.WriteLine("Kaç kelime girmek istiyorsunuz?: ");
            sayi_N = int.Parse(Console.ReadLine());

            string[] dizi = new string[sayi_N];

            for (int i = 0; i < dizi.Length; i++)
            {
                sayac++;
                System.Console.WriteLine(sayac + ". kelimeyi giriniz: ");
                dizi[i] = Console.ReadLine(); 
            }

            Array.Reverse(dizi);

            foreach (var dz in dizi)
            {
                System.Console.Write(dz + ", ");
            }
        }
    }
}
