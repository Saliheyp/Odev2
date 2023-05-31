using System;
using System.Collections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String cumle =Console.ReadLine();
            char[] unlu = {'a','e','i','ı','o','ö','u','ü'};
            ArrayList unluHarfler = new ArrayList();
            ArrayList unsuzHarfler = new ArrayList();


            bool harfVarMi = false;
            for (int i = 0; i < cumle.Length; i++)
            {
               if (unlu.Contains(cumle[i]))
               {
                unluHarfler.Add(cumle[i]);
               } 
               else
               {
                unsuzHarfler.Add(cumle[i]);
               }
            }
            unluHarfler.Sort();
            unsuzHarfler.Sort();
            foreach (var item in unluHarfler)
            {
                Console.WriteLine(item);
            }
            foreach(var item in unsuzHarfler)
            {
                Console.WriteLine(item);
            }

            
            
        }
    }
}