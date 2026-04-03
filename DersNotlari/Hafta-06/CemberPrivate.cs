using System;

namespace Nesne_Tabanlı_Programlama_Hafta_6
{
    public class CemberPrivate
    {
        private double yaricap = 1;
        private static int nesneSayisi = 0;

        private CemberPrivate()
        {
            nesneSayisi++;
            yaricap = 5;
        }

        public CemberPrivate(double yaricap)
        {
            this.yaricap = yaricap;
            nesneSayisi++;
        }

        public double AlanHesapla()
        {
            return yaricap * yaricap * Math.PI;
        }

        public double CevreHesapla()
        {
            return 2 * Math.PI * yaricap;
        }

        public double Yaricap
        {
            get { return yaricap; }
            set { yaricap = value; }
        }

        public static int NesneSayisi
        {
            get { return nesneSayisi; }
            set { nesneSayisi = value; }
        }
    }
}
