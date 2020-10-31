using System;

namespace haft3odev1
{
    class Program
    {
        static void Main(string[] args)
        {
           
              
            //BÜYÜK-SAYIYI-BULMA

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
                Console.WriteLine("İki sayı birbirine eşittir.");

            Console.ReadLine();
        }
    }
}

            
           
            /*
             
          //ÇARPIM-TABLOSU

           for (int j = 1; j <= 10; j++)
             {
                for (int i = 1; i <= 10; i++)
             {
             Console.Write("{0}*{1}={2}\t", i, j, (i * j))

           }
               Console.WriteLine();
           }
              Console.ReadKey();
           }




           /*


            //VİZE-FİNAL-HESAPLAMA

            int vize, final, ort;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.4 + final * 0.6);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50 || final < 50)
                Console.WriteLine("Kaldınız.");
            else
                Console.WriteLine("Geçtiniz.");
            Console.ReadKey();
        }
    }
}

        /*

         //METİN-UZUNLUĞU


        Console.Write("Metni girin ...: ");

        string metin = Console.ReadLine();

        int uzunluk = metin.Length;



        Console.Write("Girdiğiniz metnin uzunluğu ..=" + uzunluk);
        Console.ReadLine();
      }
   }
}



/*

    
       //ÇARPMA-İŞLEMİ

      int sayi1, sayi2, sonuc = 0;
      Console.Write("1. sayıyı giriniz : ");
      sayi1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("2. sayıyı giriniz : ");
       sayi2 = Convert.ToInt32(Console.ReadLine());
       for (int i = 1; i <= sayi2; i++)
    {
       sonuc = sayi1 + sonuc;
    }
      Console.WriteLine("Çarpım Sonucu : " + sonuc);
      Console.ReadKey();
     }
   }
}


*/
