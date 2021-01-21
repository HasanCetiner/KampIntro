using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{

    //naming convention
    //syntax

    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sebete eklendi : ", urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int StokAdedi)
        {
            Console.WriteLine("Tebrikler. Sebete eklendi : ", urunAdi);


        }
    }
}
