using System;

namespace Sayitahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int sabit = rnd.Next(1, 100);
            int tahmin;
            int sayac = 0;

            do
            {
                sayac = sayac + 1;

                Console.Write(sayac + ". sayıyı girin : ");
                tahmin = int.Parse(Console.ReadLine());

                if (tahmin < sabit && sayac != 7)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else if (tahmin > sabit && sayac != 7)
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }


            } while (tahmin != sabit && sayac < 7);

            if (sabit == tahmin)
            {
                Console.WriteLine("Sayı " + sayac + " adet denemede bulundu. Tebrikler");
            }
            else
            {
                Console.WriteLine("Deneme hakknıız kalmadı kaybettiniz.");

            }

            Console.WriteLine("bulunmaya çalışan sayı : " + sabit);
        }
    }
}
