using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama_Hafta_5
{
    internal class Program
    {
        /* default değerler
        public class Ogrenci
        {
            // tanımlama yapılmadığında:
            public string adi; // null döner
            public int yasi; // 0 döner
            public bool YBSmi; // false döner
            public char cinsiyet; // boşluk döner

        }
        */

        /* TV ÖRNEĞİ AÇ KAPA KANAL LİSTESİ VS
        public class TV
        {
            public int kanal = 1;
            public int sesseviyesi = 1;
            bool acikmi = false;
            public TV() // yapıcı metot
            {

            }
            public void ac()
            {
                acikmi = true;
            }
            public void kapat()
            {
                acikmi = false;
            }
            public void KanaliAyarla(int yeniKanal)
            {
                if (acikmi && yeniKanal >= 1 && yeniKanal <= 120)
                {
                    kanal = yeniKanal;
                }

            }
            public void SesAyarla(int yeniSes)
            {
                if (acikmi && yeniSes >= 1 && yeniSes <= 7)
                {
                    sesseviyesi = yeniSes;
                }
            }
            public void KanalYukari()
            {
                if (acikmi && kanal < 120)
                {
                    kanal++;
                }
            }
            public void KanalAsagi()
            {
                if (acikmi && kanal > 1)
                {
                    kanal--;
                }
            }
            public void SesYukari()
            {
                if (acikmi && sesseviyesi < 7)
                {
                    sesseviyesi++;
                }
            }
            public void SesAsagi()
            {
                if (acikmi && sesseviyesi > 1)
                {
                    sesseviyesi--;
                }
            }

        }
        */

        /* Cember class ornek
        public class Cember
        {
            // Parametreli constructor metot tek başına tanımlanabilir. Parametresiz olan yalnızca ayrıca ihtiyaç varsa eklenir.

            public double yaricap = 1;

            public Cember() // parametresiz constructor metot
            {

            }
            public Cember(double yaricap) // parametreli constructor metot
            {
                this.yaricap = yaricap;
            }
            public double AlanHesapla()
            {
                return yaricap * yaricap * Math.PI;
            }
            public double CevreHesapla()
            {
                return 2 * yaricap * Math.PI;  // Math.PI --> Pi sayısı  , pow(taban,üs) de kullanılabilir
            }
            public void YaricapGuncelle(double yeniYaricap)
            {
                yaricap = yeniYaricap;
            }
        }
        */

            static void Main(string[] args)
            {
            /* Random sayı üretme
            Random r1 = new Random(); // Aynı seed verilirse aynı sayı dizisini üretir. Çok kısa aralıklarla oluşturulan örneklerde benzer sonuçlar görülebilir.
            for (int i = 0; i < 10; i++)
            {
                Console.Write(r1.Next(1000));
            }
            Console.WriteLine();

            Random r2 = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(r2.Next(1000));
            }
            */



             

             DateTime simdi = DateTime.Now; // Şimdiki zaman
             Console.WriteLine("Şuan: " + simdi);
             Console.WriteLine("Bugün: " + simdi.DayOfWeek); // Hangi gün
             Console.WriteLine("Sadece tarih: " + simdi.ToShortDateString()); // sadece tarih
             Console.WriteLine("Sadece saat: " + simdi.ToShortTimeString()); // sadece saat
             simdi = simdi.AddYears(10); // Bugüne 10 yıl ekledir addDay , addWeek gibi metotlar da var
             Console.WriteLine("10 sene sonra Gelecekte bugün: " + simdi);

             DateTime dt = new DateTime(2025, 10, 26, 10, 35, 14);
             Console.WriteLine("Tarih: {0:f}", dt);
             Console.WriteLine("Gün:{0:dddd}", dt);
             Console.WriteLine("Sadece Tarih: {0:D}", dt);
             Console.WriteLine("Sadece Saat: {0:T}", dt);

            


            /* tv örneği
            TV tv1 = new TV(); tv1.ac(); tv1.KanaliAyarla(28); tv1.SesAyarla(4); Console.WriteLine("1. TV Kanal: " + tv1.kanal + " Ses Seviyesi: " + tv1.sesseviyesi);
            TV tv2 = new TV(); tv2.ac(); tv2.KanaliAyarla(35); tv2.SesAyarla(6); Console.WriteLine("2. TV Kanal: " + tv2.kanal + " Ses Seviyesi: " + tv2.sesseviyesi);
            tv2.kapat();
            tv2.KanalYukari();
            tv2.KanalYukari(); 
            tv2.SesYukari(); 
            Console.WriteLine("2. TV Kanal: " + tv2.kanal + " Ses Seviyesi: " + tv2.sesseviyesi);
            */


            /* Cember class ornek

               // 1. Yöntem
               Cember c1 = new Cember();
               c1.YaricapGuncelle(5);
               Console.WriteLine("Alanı: "+c1.AlanHesapla()+" Çevresi: "+c1.CevreHesapla());


               //2.Yöntem
               Cember c2 = new Cember(10);
               Console.WriteLine("Alanı: " + c2.AlanHesapla() + " Çevresi: " + c2.CevreHesapla());


               //3.Yöntem
               Console.WriteLine("Alanı: " + new Cember(100).AlanHesapla() +" Çevresi: "+new Cember(100).CevreHesapla());
               Console.ReadKey();
                */

            /* Cember class ornek
            Cember c1 = new Cember(5);
                Cember c2 = new Cember(10);
                c1 = c2; // Bu eşitleme yapıldıktan sonra referans tiplilerde eşitleme yapıldıktan sonra değişiklik yapılsa bile ikiside c2 gibi davranır
                c1.yaricap = 25;  // yani c1 in sonradan yarıçapının değişmesi durumdunda her iki nesnenin de yarıçapı değişiyor sanki aynı nesnelermiş gibi davranıyor eşitleme yapıldığı için.
                Console.WriteLine("C1 in yarıçapı: " + c1.yaricap);
                Console.WriteLine("C2 nin yarıçapı: " + c2.yaricap);
                Console.ReadKey();
            */



        }

    }
}



