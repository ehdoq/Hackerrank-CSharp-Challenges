using System;

namespace Ders02
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byteMax = byte.MaxValue;
            byte byteMin = byte.MinValue;
            Console.WriteLine("byte ----- Max: " + byteMax + " ----- Min: " + byteMin + "----- 1 bayt");

            sbyte sbyteMax = sbyte.MaxValue;
            sbyte sbyteMin = sbyte.MinValue;
            Console.WriteLine("sbyte ----- Max: " + sbyteMax + " ----- Min: " + sbyteMin  + "----- 1 bayt");
           
            short shortMax = short.MaxValue;
            short shortMin = short.MinValue;
            Console.WriteLine("short ----- Max: " + shortMax + " ----- Min: " + shortMin + "----- 2 bayt");
            
            ushort ushortMax = ushort.MaxValue;
            ushort ushortMin = ushort.MinValue;
            Console.WriteLine("ushort ----- Max: " + ushortMax + " ----- Min: " + ushortMin + "----- 2 bayt");

            UInt16 UInt16Max = UInt16.MaxValue;
            UInt16 UInt16Min = UInt16.MinValue;
            Console.WriteLine("UInt16 ----- Max: " + UInt16Max + " ----- Min: " + UInt16Min + "----- 2 bayt");

            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine("int ----- Max: " + intMax + " ----- Min: " + intMin + "----- 4 bayt");

            uint uintMax = uint.MaxValue;
            uint uintMin = uint.MinValue;
            Console.WriteLine("uint ----- Max: " + uintMax + " ----- Min: " + uintMin + "----- 4 bayt");

            UInt32 UInt32Max = UInt32.MaxValue;
            UInt32 UInt32Min = UInt32.MinValue;
            Console.WriteLine("UInt32 ----- Max: " + UInt32Max + " ----- Min: " + UInt32Min + "----- 4 bayt");

            UInt64 UInt64Max = UInt64.MaxValue;
            UInt64 UInt64Min = UInt64.MinValue; 
            Console.WriteLine("UInt64 ----- Max: " + UInt64Max + " ----- Min: " + UInt64Min + " ----- 8 bayt");

            long longMax = long.MaxValue;
            long longMin = long.MinValue; 
            Console.WriteLine("long ----- Max: " + longMax + " ----- Min: " + longMin + " ----- 8 bayt");

            ulong ulongMax = ulong.MaxValue;
            ulong ulongMin = ulong.MinValue; 
            Console.WriteLine("ulong ----- Max: " + ulongMax + " ----- Min: " + ulongMin + " ----- 8 bayt");

            float floatMax = float.MaxValue;
            float floatMin = float.MinValue; 
            Console.WriteLine("float ----- Max: " + floatMax + " ----- Min: " + floatMin + " ----- 4 bayt");

            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue; 
            Console.WriteLine("double ----- Max: " + doubleMax + " ----- Min: " + doubleMin + " ----- 8 bayt");

            decimal decimalMax = decimal.MaxValue;
            decimal decimalMin = decimal.MinValue; 
            Console.WriteLine("decimal ----- Max: " + decimalMax + " ----- Min: " + decimalMin + " ----- 16 bayt");

            Console.WriteLine("char ----- Tek karakter ----- 2 bayt");

            Console.WriteLine("string ----- Sınırsız ----- Sınırsız bayt");

            /*
            //Kısa Sayılar
            byte b = 1;         //1 Bayt
            sbyte sb = 1;       //1 Bayt
            short sh = 1;       //2 Bayt
            ushort ush = 1;     //2 Bayt

            //Uzun Sayılar
            UInt16 ui16 = 1;    //2 Bayt
            int i = 1;          //4 Bayt
            uint ui = 1;        //4 Bayt
            UInt32 ui32 = 1;    //4 Bayt
            UInt64 ui64 = 1;    //8 Bayt
            long l = 1;         //8 Bayt
            ulong ul = 1;       //8 Bayt

            //Ondalıklı Sayılar
            float flt = 1F;       //4 Bayt
            double dbl = 1.0;     //8 Bayt
            decimal dcml = 1;      //16 Bayt

            //Metin
            char c = 'a';       //2 Bayt
            string s = "Yazı";  //Sınırsız
            
            //Doğru-Yanlış/Evet-Hayır
            bool tr = true;
            bool fls = false;
            */
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            bool bl = (5 * 2) > 9;
            Console.WriteLine(bl);

            string s1 = String.Empty, s2, s3;
            string yas = "24";

            int sayi = 20 + Convert.ToInt32(yas);
            int sayi2 = 20 + int.Parse(yas);

            s1 = "Merhaba";
            s2 = "Mustafa";
            s3 = "GEDİK";

            Console.WriteLine(s1 + " " + s2 + " " + s3 + ", " + "Yaş: " + yas + " --- " + sayi.ToString() + " --- " + sayi2);
            
            string tarih = DateTime.Now.ToString("dd.MM.yyyy");
            string tarih2 = DateTime.Now.ToString("dd/MM/yyyy");
            string saat = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(tarih);
            Console.WriteLine(tarih2);
            Console.WriteLine(saat);
        }
    }
}
