using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdı = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elamsı";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");
            }

            Console.WriteLine("---------Metotlar-------------");
            //instance = örnek(class örneği oluşturuyoruz)
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 6);
            sepetManager.Ekle2("Elma", "Yeşil elma", 9, 6);
            sepetManager.Ekle2("Diyarbakır", "Diyarbakır karpuzu", 80, 9);
        }
    }
}