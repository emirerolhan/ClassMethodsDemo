using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Emirhan";
            musteri1.MusteriSoyadi="Erol";
            musteri1.MusteriId =321123 ;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi ="Enes";
            musteri2.MusteriSoyadi = "Eğil";
            musteri2.MusteriId =432234;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Ali Efe";
            musteri3.MusteriSoyadi = "Erol";
            musteri3.MusteriId = 098890;

            Musteri[] musteriler = {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            Console.WriteLine("--------------------------------------------");
            musteriManager.Silme(musteri2);
            Console.WriteLine("--------------------------------------------");
            musteriManager.Listeleme(musteriler);
            Console.WriteLine("--------------------------------------------");

            Console.ReadLine();
        }
    }
}
