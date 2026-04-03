using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesne_Tabanlı_Programlama_Hafta_6
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           
            StatikCember c1 = new StatikCember(10);
            Console.WriteLine(" c1 Yarıçapı: " + c1.yaricap);
            Console.WriteLine("İlk Nesne Sayısı: " + StatikCember.GetNesneSayisi());
            c1.YaricapGuncelle(20);
            Console.WriteLine("c1 Güncel Yarıçap:" + c1.yaricap);
            Console.WriteLine("Nesne Sayısı: " + StatikCember.GetNesneSayisi());

            StatikCember c2 = new StatikCember(20);
            Console.WriteLine("c2 Yarıçapı: " + c2.yaricap);
            Console.WriteLine("Nesne Sayısı: " + StatikCember.GetNesneSayisi());

            StatikCember.nesneSayisi = 100;
            Console.WriteLine("Nesne Sayısı: " + StatikCember.GetNesneSayisi());
            Console.ReadKey();

            */

            /*
             
            C1 o = new C1();
            o.x = 1;
            o.y = 10;
            o.z = 30;

            o.m1();
            o.m2();
            o.m3();

            */
            CemberPrivate c3 = new CemberPrivate(10);
            Console.WriteLine("Yarıçap " + c3.Yaricap);
            Console.WriteLine("Alanı: " + c3.AlanHesapla());
            c3.Yaricap = c3.Yaricap * 3;
            Console.WriteLine("Yarıçapı :" + c3.Yaricap);
            Console.WriteLine("Alanı: " + c3.AlanHesapla());

            Console.WriteLine("Nesne Sayısı: " + CemberPrivate.NesneSayisi);

            Console.ReadKey();
        }
    }
}
