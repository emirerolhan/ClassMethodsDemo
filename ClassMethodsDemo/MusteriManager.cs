using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodsDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri No : "+musteri.MusteriId + " "+
                "Adı : " + musteri.MusteriAdi+" "+
                "Soyadı: " + musteri.MusteriSoyadi+" Sisteme eklendi");
        }
        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri No : " + musteri.MusteriId + " " +
                "Adı : " + musteri.MusteriAdi + " " +
                "Soyadı: " + musteri.MusteriSoyadi + " Sisteme den silindi");

        }

        public void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri item in musteriler)
            {
                Console.WriteLine(item.MusteriAdi+" "+item.MusteriSoyadi);
            }


        }

        
    }
}
