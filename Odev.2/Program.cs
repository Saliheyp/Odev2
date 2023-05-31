using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> sayilar = new List<int>();
            ArrayList sayiilar = new ArrayList();
            List<int> asal = new List<int>();
            List<int> nonAsal = new List<int>();
            int asalOrtalama = 0;
            int nonAsalOrtalama = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine((i+1)+".sayıyı giriniz:");
            string girilensayi = Console.ReadLine();
            if (IsNumeric(girilensayi))
            {
                int sayi = int.Parse(girilensayi);
                if(sayi >0)
                {
                 sayilar.Add(sayi);
                }
                else
                {
                    i--;
                Console.WriteLine("lütfen bir doğal sayı giriniz");
                }
            }
            else
            {
                i--;
                Console.WriteLine("lütfen bir doğal sayı giriniz");
            }
           
        }
        foreach (var item in sayilar)
        {
            if(asalmi(item))
            {
                asal.Add(item);
            }
            else
            nonAsal.Add(item);
        }
        
        asal.Sort();
        nonAsal.Sort();
        Console.WriteLine("Asal Sayılar");
        foreach (var item in asal)
        {
            Console.WriteLine(item);
            asalOrtalama += item;

        }
        Console.WriteLine("Asal olmayan Sayılar");
       foreach (var item in nonAsal)
        {
            Console.WriteLine(item);
            nonAsalOrtalama += item;
        }
        Console.WriteLine("Asal Sayı Sayısı: "+asal.Count());
        Console.WriteLine("Asal sayı ortalaması: "+asalOrtalama/asal.Count());
        Console.WriteLine("Asal olmayan Sayı Sayısı: "+nonAsal.Count());
        Console.WriteLine("Asal olmayan Sayı ortlaması: "+nonAsalOrtalama/nonAsal.Count());

        
       
            
        }
        public static bool asalmi(int a)
        {
            if (a<=1)
            return false;
            for (int i = 2; i < a; i++)
            {
                if(a%i==0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsNumeric(string a)
        {
           
          return int.TryParse(a, out _);
        }

    }
}