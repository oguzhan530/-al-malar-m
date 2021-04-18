using System;

namespace kullanicinin_girdiği_sayının__iki_katını_alma
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Bir sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            sayi = sayi * 2;
            Console.WriteLine("Sonuc:"+sayi);
        }
    }
}
