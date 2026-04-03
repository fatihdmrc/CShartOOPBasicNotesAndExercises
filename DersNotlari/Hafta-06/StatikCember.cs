using System;

namespace Nesne_Tabanlı_Programlama_Hafta_6
{
    public class StatikCember
    {
        public double yaricap = 1;
        public static int nesneSayisi = 0;

        public StatikCember()
        {
            nesneSayisi++;
            yaricap = 5;
        }

        public StatikCember(double yYaricap)
        {
            yaricap = yYaricap;
            nesneSayisi++;
        }

        public double AlanHesapla()
        {
            return yaricap * yaricap * Math.PI;
        }

        public double CevreHesapla()
        {
            return 2 * yaricap * Math.PI;
        }

        public void YaricapGuncelle(double yeniYaricap)
        {
            yaricap = yeniYaricap;
        }

        public static int GetNesneSayisi()
        {
            return nesneSayisi;
        }
    }
}
