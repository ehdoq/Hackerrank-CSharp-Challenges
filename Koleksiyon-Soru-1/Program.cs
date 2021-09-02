using System;
using System.Collections;

namespace Koleksiyon_Soru_1
{
   
    class Program
    {
        //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. 
        //(ArrayList sınıfını kullanara yazınız.)
        static ArrayList asalListe = new ArrayList();
        static ArrayList asalOlmayanListe = new ArrayList();
        static void asalMi(int sayi)
        { 
            int i = 2, kontrol = 0;
            while (i < sayi)
            {
                if (sayi % i == 0)
                {
                    kontrol++;
                }
                i++;
            }
            
            if(kontrol != 0)
            {
                asalOlmayanListe.Add(sayi);
            }
            else
            {
                asalListe.Add(sayi);
            }
        }
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
            int sayac = 1;      
            while (sayac <= 20)
            {
                System.Console.WriteLine(sayac + ". sayıyı girin: ");
                string sayimi = Console.ReadLine();
                if (sayiMi(sayimi))
                {
                    sayac++;
                    int sayi = int.Parse(sayimi);
                    asalMi(sayi);
                }
                else
                {
                    System.Console.WriteLine("Lütfen sayı girişi yapınız.");
                }
            }

            foreach (var asal in asalListe)
            {
                System.Console.Write(asal + ", ");
            }

            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();

            foreach (var asalolmayan in asalOlmayanListe)
            {
                System.Console.Write(asalolmayan + ", ");
            }
        }
    }
}
