using System;

namespace haft3odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1, sayi2;

            Console.WriteLine("1.sayıyı giriniz:");
            sayi1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz:");
            sayi2 = Convert.ToInt16(Console.ReadLine());

            if (sayi1 > sayi2)

                Console.WriteLine("1.Sayı Büyük ");
            else if (sayi2 > sayi1)
                Console.WriteLine("2.Sayı Büyük ");
            else
                Console.WriteLine("İki sayı birbirine eşittir");

            Console.ReadLine();
        }
    }
}
