using System;
using System.Collections;

namespace SoruIki
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int buyukOrt=0;
            int kucukOrt=0;

            ArrayList sayilar = new ArrayList();
            List<int> kucuk = new List<int>();
            List<int> buyuk = new List<int>();

            for (int i = 0; i < 20; i++)
            {

             Console.WriteLine("Sayı giriniz:");
             string girilenSayi = Console.ReadLine();
             int sayi;
             if (int.TryParse(girilenSayi, out sayi))
             {
                sayilar.Add(sayi);
             }
             else{
                i--;
                Console.WriteLine("Lütfen geçerli bir sayı giriniz.");
             }
            }
            sayilar.Sort();
            kucuk.Add((int)sayilar[0]) ;
            kucuk.Add((int)sayilar[1]) ;
            kucuk.Add((int)sayilar[2]) ;
            buyuk.Add((int)sayilar[17]);
            buyuk.Add((int)sayilar[18]);
            buyuk.Add((int)sayilar[19]);
            foreach (var item in buyuk)
            {
                buyukOrt += item;
            }
            foreach (var item in kucuk)
            {
                kucukOrt+=item;
            }
            Console.WriteLine("En büyük 3 sayının toplamı: "+buyukOrt);
            Console.WriteLine("En büyük 3 sayının ortalaması: "+buyukOrt/3);
            Console.WriteLine("En küçük 3 sayının toplamı: "+kucukOrt);
            Console.WriteLine("En küçük 3 sayının ortalaması: "+kucukOrt/3);
        }
    }
}