using System;

namespace Ders06AlgoritmaSorusuDort
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;

            System.Console.WriteLine("Bir cümle girin.");
            cumle = Console.ReadLine();

            string[] kelime = cumle.Split(' ');

            int harfSayisi = cumle.Length, kelimeSayisi = kelime.Length;

            System.Console.WriteLine("Cümledeki harf sayısı: " + harfSayisi + " ve cümledeki kelime sayısı: " + kelimeSayisi);
        }
    }
}
