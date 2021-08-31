using System;

namespace Ders01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string isim = "Mustafa", soyisim = "GEDİK";
            Console.WriteLine(isim + " " + soyisim);

            Console.WriteLine("Adınızı giriniz: ");
            string isim2 = Console.ReadLine();

            Console.WriteLine("Soyadınızı giriniz: ");
            string soyisim2 = Console.ReadLine();

            Console.WriteLine(isim2 + " " + soyisim2);
        }
    }
}
