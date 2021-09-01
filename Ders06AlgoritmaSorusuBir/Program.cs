using System;

namespace Ders06AlgoritmaSorulari
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi_N = 0, sayac = 0;
            int[] dizi = new int[sayi_N];

            System.Console.WriteLine("Kaç sayı girmek istiyorsunuz?: ");
            sayi_N = int.Parse(Console.ReadLine());

            for (int i = 0; i < dizi.Length; i++)
            {
                sayac++;
                System.Console.WriteLine(sayac + ". pozitif sayıyı giriniz: ");
                dizi[i] = int.Parse(Console.ReadLine());
            }

            foreach (var dz in dizi)
            {
                if(dz % 2 == 0)
                    System.Console.Write(dz + ", ");
            }
        }
    }
}
