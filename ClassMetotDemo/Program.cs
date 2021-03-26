using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "000000000000001";
            musteri1.Adi = "Türk";
            musteri1.Soyadi = "Er";
            musteri1.TelNo = 24562215452;
            musteri1.Adres = "Manisa";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "000000000000002";
            musteri2.Adi = "Hayati";
            musteri2.Soyadi = "Sönmez";
            musteri2.TelNo = 41236520384;
            musteri2.Adres = "Çanakkale";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriNo = "000000000000003";
            musteri3.Adi = "Alev";
            musteri3.Soyadi = "Çelebi";
            musteri3.TelNo = 89695472302;
            musteri3.Adres = "Ankara";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriNo = "000000000000004";
            musteri4.Adi = "Cüneyt";
            musteri4.Soyadi = "Çakmak";
            musteri4.TelNo = 85026984140;
            musteri4.Adres = "Muğla";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.MusteriNo = "000000000000005";
            musteri5.Adi = "Ceylan";
            musteri5.Soyadi = "Kara";
            musteri5.TelNo = 15698740358;
            musteri5.Adres = "Çankırı";

            Musteri musteri6 = new Musteri();
            musteri6.Id = 6;
            musteri6.MusteriNo = "000000000000006";
            musteri6.Adi = "Ece";
            musteri6.Soyadi = "Kaleli";
            musteri6.TelNo = 95874563023;
            musteri6.Adres = "Samsun";

            Musteri musteri7 = new Musteri();
            musteri7.Id = 7;
            musteri7.MusteriNo = "000000000000007";
            musteri7.Adi = "Hamza";
            musteri7.Soyadi = "Paşa";
            musteri7.TelNo = 55285185240;
            musteri7.Adres = "Aksaray";

            Musteri musteri8 = new Musteri();
            musteri4.Id = 4;
            musteri4.MusteriNo = "000000000000008";
            musteri4.Adi = "Elçin";
            musteri4.Soyadi = "Çınar";
            musteri4.TelNo = 12658456524;
            musteri4.Adres = "Mersin";

            MusteriManager musteriMenager = new MusteriManager();
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5, musteri6, musteri7, musteri8 };

            Console.WriteLine("-----------Müşteri Ekle----------");
            musteriMenager.Ekle(musteri1);
            musteriMenager.Ekle(musteri2);
            musteriMenager.Ekle(musteri3);
            musteriMenager.Ekle(musteri4);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-----------Müşteri Sil-----------");
            musteriMenager.Sil(musteri4);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("---------Müşteri Güncelle--------");
            musteriMenager.Guncelle(musteri2);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("-------Müşterileri Listele-------");
            musteriMenager.Listele(musteriler);
            Console.ReadLine();
        }
    }
}
