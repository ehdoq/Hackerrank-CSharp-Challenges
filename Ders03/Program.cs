using System;

namespace Ders03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Birinci sayıyı girin: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("İkinci sayıyı girin: ");
                int b = int.Parse(Console.ReadLine());
                int c = a + b;

                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir Hata Oluştu: "+ ex.Message);
            }
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");
            }
        }
    }
}
