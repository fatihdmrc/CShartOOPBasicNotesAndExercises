// class oluşturmak --> Nokta
/*
Nokta n1 = new Nokta();
n1.x = 5;
n1.y = 10;
Console.WriteLine("Kordinatları : "+n1.x+","+n1.y);

public class Nokta
{
    public int x;
    public int y;
}
*/

// Yeni class oluşturalım --> Araba
/*
Araba araba1 = new Araba();
araba1.renk = "Kırmızı";
araba1.marka = "BMW";
araba1.model = "2018";
araba1.vitesTipi = "Otomatik";
araba1.yakitTipi = "Dizel";
araba1.kapiSayisi = 5;
araba1.km = 12000;

Console.WriteLine("Arabanın özellikleri; \nArabanın Rengi:" + araba1.renk + " \n" +
    "Arabanın Markası:" + araba1.marka + "\n" + "Arabanın modeli:" + araba1.model + "\n" + "Arabanın vites tipi:" + araba1.vitesTipi + "\n" +
    "Arabanın Yakıt tipi:" + araba1.yakitTipi + "\n" + "Arabanın kapı sayısı:" + araba1.kapiSayisi + "\n" +
    "Arabanın km:" + araba1.km);


class Araba
{
    public string renk;
    public string marka;
    public string model;
    public string vitesTipi;
    public string yakitTipi;
    public int kapiSayisi;
    public int km;
}
// Not: Public her yerden erişilebilir. Private sadece tanımlandığı sınıftan erişilebilir.
// Internal sadece bulunduğu projeden erişilebilir. 
// Protected sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir
// Protected Internal : Sadece tanımlandığı sınıfta yada o sınıfı miras alan sınıflardan erişilebilir.
//Ayrıca tanımlamanın aynı proje içerisinde olma şartı yoktur.Protected dan farkı budur.
// Eğer erişim belirteci belirtilmemişse o sınıf Internal 'dır.
*/

// Overload (Metotlarda Aşırı Yükleme) --> Metotları farklı referans tipine göre tanımlamak
/*

// Console.WriteLine(Math.Max(10,12)); // Max metodu büyük olanı verir.


// Bu metot Math sınıfının Max metodudur. Aynı metot üzerinden hem int hemde double 
// değerler karşılaştırıp büyük olan bulunabilir. Bunu yapan aynı metodun farklı referans 
//tipleri ile yani int,double,long gibi farklı refarans tipleri ile tanımlanmış olmasıdır.
// Buna aşırı yükleme diyoruz.

Console.WriteLine(Overloading.bmax(32,35));
Console.WriteLine(Overloading.bmax(1.7,2.3));
class Overloading
{
    public static int bmax(int sayi1,int sayi2) // İnt metot
      // nesne oluşturmadan sınıf üzerinden erişmek için static terimini ekledik.
    { // Yoksa sınıfta nesne üretip o nesne üzerinden bu metoda erişmemiz gerekecekti.                                  
        if (sayi1 > sayi2)
        {
            return sayi1;
        }
        else if (sayi2 > sayi1)
        {
            return sayi2;
        }
        else
        {
            return 0;
        }
    }
    public static double bmax(double sayi1, double sayi2) // Double metot
    {                                   
        if (sayi1 > sayi2)
        {
            return sayi1;
        }
        else if (sayi2 > sayi1)
        {
            return sayi2;
        }
        else
        {
            return 0;
        }
    }
}
*/

// Sayı tahmin oyunu 
Random rnd = new Random();
int sayi = rnd.Next(0, 50);
Console.WriteLine(sayi);
int sayac = 0;
while (true)
{
    Console.WriteLine("1 ile 50 arasında bir sayı giriniz: ");
    int girilensayi = Convert.ToInt32(Console.ReadLine());
    sayac++;
    if (girilensayi == sayi)
    {
        Console.WriteLine("Tebrikler sayıyı doğru tahmin ettiniz");
        Console.WriteLine(sayac +". tahminde doğruya ulaştınız.");
        break;
    }
    else
    {
        if (girilensayi>sayi)
        {
            Console.WriteLine("Daha küçük bir sayı giriniz.");
        }
        else if(girilensayi < sayi)
        {
            Console.WriteLine("Daha büyük bir sayı giriniz.");
        }
        Console.WriteLine("Lütfen tekrar tahmin edin.");
        Console.WriteLine("--------------------------------");
    }
}
Console.WriteLine("Oyun Bitti Görüşmek Üzere :)");