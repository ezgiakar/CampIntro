using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ezgi" ;
            int yasi = 24;
            //class da string gibi int gibi bir veri oluşturur. Tipi kurs olur. içinde 3 tane eleman içerir

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            //3 özelliği var ve onları veriyoruz. Değerlerini atıypruz. sınıf tanımlıyoruz, özellik atıyoruz
            // newliyoruz ve değer atıyoruz.


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Ezgi Akar";
            kurs2.IzlenmeOrani = 100;

            //Kurs veri tipi olur.
            // Console.WriteLine(kurs1.KursAdi + " "+ kurs1.Egitmen);
            //string yerine kurs yazdım ve içinde kursu tanımlayabilirim dizi şeklinde.
            Kurs[] kurslar = new Kurs[] {kurs1, kurs2 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }

            Console.WriteLine("Hello World!");
        }
    }

    //prop = özellikten gelir. 3 tane değişken var.
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen{ get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
