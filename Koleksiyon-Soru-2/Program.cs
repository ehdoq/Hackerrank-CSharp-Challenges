using System;

namespace Koleksiyon_Soru_2
{
    class Program
    {
        //Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
        //her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
        //(Array sınıfını kullanarak yazınız.)
        static bool sayiMi(string deger)
        {
            try
            {
                int.Parse(deger);
                return true;  
            }
            catch (Exception)
            {
                return false; 
            }
        }

        static void Main(string[] args)
        {
            int sayac = 1, i = 0, enBuyukUc = 0, enKucukUc = 0; 
            int[] dizi = new int[20];     
            while (sayac <= 20)
            {
                System.Console.WriteLine(sayac + ". sayıyı girin: ");
                string sayimi = Console.ReadLine();
                if (sayiMi(sayimi))
                {
                    sayac++;
                    int sayi = int.Parse(sayimi);
                    dizi[i] = sayi;
                    i++;
                }
                else
                {
                    System.Console.WriteLine("Lütfen sayı girişi yapınız.");
                }        
            }

            Array.Sort(dizi);

            enBuyukUc = (dizi[17] + dizi[18] + dizi[19]) / 3;
            enKucukUc = (dizi[0] + dizi[1] + dizi[2]) / 3;

            System.Console.WriteLine();

            System.Console.WriteLine("En Büyük Üç Eleman: ");
            System.Console.WriteLine(dizi[17] + ", " + dizi[18] + ", " + dizi[19]);
            System.Console.WriteLine("En Küçük Üç Eleman: ");
            System.Console.WriteLine(dizi[0] + ", " + dizi[1] + ", " + dizi[2]);

            System.Console.WriteLine("En Büyük Üç Elemanın Ortalaması: " + enBuyukUc + "\n" + 
                                     "En Küçük Üç Elemanın Ortalaması: " + enKucukUc + "\n" + 
                                     "En Büyük ve En Küçük Üç Elemanın Ortalama Toplamı: " + (enBuyukUc + enBuyukUc));
        }
    }
}
