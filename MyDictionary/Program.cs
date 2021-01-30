using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
         public static void Main(string[] args)
        {
            Dictionary<string, int> ilPlaka = new Dictionary<string, int>();

            ilPlaka.Add("Konya", 42);
            ilPlaka.Add("Ordu", 52);
            ilPlaka.Add("Çorum", 19);
            ilPlaka.Add("Antalya", 07);
            ilPlaka.Add("Karaman", 70);
            ilPlaka.Add("Sinop", 57);

            foreach (var sehirler in ilPlaka)
            {
                Console.WriteLine(sehirler);
            }
        }
    }
}
