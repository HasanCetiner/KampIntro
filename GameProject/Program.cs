using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager ());  /*e devlette yeni tanımlama sistemine geçildiği zaman hiç
            kendimi yormadan "new UserValidationManager ()" kısmını silip yeni sistemi yazıveriyorum :) */
            gamerManager.Add(new Gamer
            {
                ID = 1,
                BirthYear = 1985,
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                IdentityNumber = 12345

            });
        }
    }
}
