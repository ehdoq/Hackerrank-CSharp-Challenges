using System;

namespace Ders06AlgoritmaSorusuIki
{
    class Program
    {
        static void Main(string[] args)
        {  
            int sayi_N = 0, sayac = 0, sayi_M = 0;

            System.Console.WriteLine("Kaç sayı girmek istiyorsunuz?: ");
            sayi_N = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Bölünecek sayıyı girin: ");
            sayi_M = int.Parse(Console.ReadLine());

            int[] dizi = new int[sayi_N];

            for (int i = 0; i < dizi.Length; i++)
            {
                sayac++;
                System.Console.WriteLine(sayac + ". pozitif sayıyı giriniz: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var dz in dizi)
            {
                if((dz % sayi_M == 0) || (dz == sayi_M))
                    System.Console.Write(dz + ", ");
            }
        }
    }
}
