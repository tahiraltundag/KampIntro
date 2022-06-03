using System;

namespace ReferenceTypes2
{
    class Program
    {
        static void Main(string[] args)
        {

            Kisi kisi1 = new Kisi();
            kisi1.Ad = "Tahir";
            kisi1.Soyad = "Altundağ";
            

            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Mehmet";
            musteri1.Soyad = "Altundağ";
            musteri1.KrediKartNumarsi = 43334343;


            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Sultan";
            calisan1.Soyad = "Altundağ";
            calisan1.CalisanNumarasi = 2311441;

            Kisi kisi2 = musteri1;
            Console.WriteLine(musteri1.Ad);

            KisiManager kisiManager = new KisiManager();
            kisiManager.Add(calisan1);
            kisiManager.Add(musteri1);
            kisiManager.Add(kisi1);

        }
    }

    class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

    }

    class Musteri:Kisi
    {
        public int KrediKartNumarsi { get; set; }
    }

    class Calisan:Kisi
    {
        public int CalisanNumarasi { get; set; }
    }

    class KisiManager
    {
        public void Add(Kisi kisi)
        {
            Console.WriteLine(kisi.Ad);
        }
    }


}
