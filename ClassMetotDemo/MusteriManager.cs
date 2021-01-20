using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteriler)
        {
            Console.WriteLine("Kayıtlı Başarılı" + "Hoşgeldiniz Sayın" + musteriler.MusteriAdi + musteriler.MusteriSoyadi);
            Console.WriteLine(musteriler.Yas + musteriler.Cinsiyet);
        }
        public void Delete(Musteri musteriler)
        {
            Console.WriteLine("Kayıt silme işlemi gerçekleştirilmiştir." + musteriler.MusteriAdi + musteriler.MusteriSoyadi);
        }
        public void List(Musteri musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("müşteri listesi başarıyla görüntülendi.");
                Console.WriteLine(musteriler.MusteriAdi + " " + musteriler.MusteriSoyadi + " " + musteriler.Yas + " " + musteriler.Cinsiyet);
            }
        }
    }
}
