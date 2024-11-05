// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace koleksiyonlar
{
    class koleksiyon
    {
        static void Main()
        {
            string isim;
            ArrayList isimliste = new ArrayList();
            Console.WriteLine("5 Adet isim giriniz");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}. İsim", i + 1);
                isim = Console.ReadLine();  
                isimliste.Add(isim);

            }
            isimliste.Sort();
            Console.WriteLine();
            Console.WriteLine("Sıralanmış hali:");
            foreach (string i in isimliste)
            {
                Console.WriteLine(i);
            }



        }
    }
}