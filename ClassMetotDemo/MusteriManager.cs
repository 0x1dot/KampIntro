using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi! :" + musteri.Adi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Sİlindi! :" + musteri.Adi);
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Güncellendi! :" + musteri.Adi);
        }

        public void Listele(Musteri[] musteri)
        {
            int i=1;
            foreach (var m in musteri)
            {
                Console.WriteLine(i + ".Müşteri ** " + m.MusteriNo + " - " + m.Adi + " - " + m.Soyadi + " - " + m.TC + " - " + m.TelNo + " - " + m.Adres);
                i++;
            }
        }
    }
}
