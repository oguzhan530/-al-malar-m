using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Ara sınav Notunuzu girniz");
            int arasnv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Finanl notunuzu giriniz");
            int finalsnv = Convert.ToInt32(Console.ReadLine());
            double ort = Convert.ToInt32(arasnv * 0.4 + finalsnv * 0.6);
            Console.WriteLine("Ortalamanız={0}", ort);
            if (finalsnv <= 45)
            {
                Console.Write("ff");
            }
            if (ort>=0 && ort<=29)
            {
               
                Console.Write("Harf notunuz=", harf);
                
            }
            else if (ort>=30&&ort<=39)
            {
                
                Console.Write("Harf notunuz=", harf);
            }
        }
    }
}
