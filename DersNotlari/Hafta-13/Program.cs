
try // Hata olma ihtimali olan kodu try kısmına yazıyoruz
{
    int[] sayilar = { 1, 2, 3 };
    Console.WriteLine(sayilar[5]); //IndexOufOfRangeException hatası verir ide'De

}
catch (Exception e) // Hata alırsak ne olacağını buraya yazıyoruz
{
    // Burda oluşan hatayı e olarak değişken halinde tutuyoruz
    Console.WriteLine("Hata mesajı: " + e.Message);
}
finally // Burası her türlü çalışacak olan kısımdır. Kodun önemli kısımlar buraya yazılabilir.
{
    Console.WriteLine("Burası her türlü çalışacak..");
}



/* Enum Yapısı ve Switch Case Yapısı ile Kullanımı

// Enum yapısı sayısal ve sabit olan değerleri ve karşılıklarını tutar
// Console.WriteLine(Aylar.Mayıs); // Çıktı  --> Mayıs 
// Console.WriteLine((int)Aylar.Mayıs); // Çıktı --> sayısal değerini verecek int'e çevirdik çünkü --> 5
//Aylar suankiay = Aylar.Ocak; // suankiay diye bir aylar tipinde bir değişken oluşturup için aylardan ocağı attık
//Console.WriteLine(suankiay); // suankiay değişkenini ekranda yazdırdık

//Switch Case ile Kullanımı
Console.WriteLine("Lütfen sayı giriniz ");
int ay = Convert.ToInt32(Console.ReadLine());
Aylar suankiay = (Aylar)ay;
switch (suankiay)
{
    case Aylar.Ocak:
        Console.WriteLine(Aylar.Ekim);
        break;
    case Aylar.Şubat:
        Console.WriteLine(Aylar.Şubat);
        break;
    case Aylar.Mart:
        Console.WriteLine(Aylar.Mart);
        break;
    case Aylar.Nisan:
        Console.WriteLine(Aylar.Nisan);
        break;
    case Aylar.Mayıs:
        Console.WriteLine(Aylar.Mayıs);
        break;
    case Aylar.Haziran:
        Console.WriteLine(Aylar.Haziran);
        break;
    case Aylar.Temmuz:
        Console.WriteLine(Aylar.Temmuz);
        break;
    case Aylar.Ağustos:
        Console.WriteLine(Aylar.Ağustos);
        break;
    case Aylar.Eylül:
        Console.WriteLine(Aylar.Eylül);
        break;
    case Aylar.Ekim:
        Console.WriteLine(Aylar.Ocak);
        break;
    case Aylar.Kasım:
        Console.WriteLine(Aylar.Kasım);
        break;
    case Aylar.Aralık:
        Console.WriteLine(Aylar.Aralık);
        break;
}

enum Aylar // Aylar enumunu oluşturduk ve referans değerini 1 den başlattık
           // otomatik olarak diğer referans artarak ilerleyecektir
{
    Ocak = 1, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
}


*/

/* Abstract Class ve interface örnek
UniversiteOgrencisi uogr1 = new UniversiteOgrencisi();
uogr1.Ad = "Ornek";
uogr1.SoyAd = "Kullanici";
uogr1.Sinifi = "2";
uogr1.OkulNo = 1000000;
uogr1.DogumYeri = "OrnekSehir";
uogr1.OkulAdi = "Ornek Universite";
uogr1.DogumTarihi = new DateTime(2001, 05, 22);
uogr1.BilgileriniYazdir();

Surucu src1 = new Surucu();
src1.Ad = "Ornek";
src1.SoyAd = "Kullanici";
src1.DogumYeri = "OrnekSehir";
src1.DogumTarihi = new DateTime(2001, 05, 22);
src1.EhliyetSinifi = "E sınıfı";
src1.EhliyetTarihi = new DateTime(2021, 01, 17);
src1.BilgileriniYazdir();
interface INufusCuzdani
{
    public string Ad { get; set; }
    public string SoyAd { get; set; }

    public string DogumYeri { get; set; }
    public DateTime DogumTarihi { get; set; }
}
interface IOgrenciKimligi : INufusCuzdani
{
    public string OkulAdi { get; set; }
    public string Sinifi { get; set; }
    public int OkulNo { get; set; }
}
interface IEhliyet : INufusCuzdani
{
    public string EhliyetSinifi { get; set; }
    public DateTime EhliyetTarihi { get; set; }
}
abstract class Insan : INufusCuzdani
{
    public abstract string Ad { get; set; }
    public abstract string SoyAd { get; set; }
    public abstract string DogumYeri { get; set; }
    public abstract DateTime DogumTarihi { get; set; }
}
abstract class Ogrenci : Insan, IOgrenciKimligi
{
    public abstract string OkulAdi { get; set; }
    public abstract string Sinifi { get; set; }
    public abstract int OkulNo { get; set; }
    public bool BursDurumu(bool durum)
    {
        return durum;
    }
    public abstract void BilgileriniYazdir();
}
class UniversiteOgrencisi : Ogrenci
{
    private string ad;
    private string soyad;
    private string dogumyeri;
    private DateTime dogumtarihi;
    private string okuladi;
    private string sinifi;
    private int okulnumara;

    public override string Ad { get { return ad; } set { ad = value; } }
    public override string SoyAd { get { return soyad; } set { soyad = value; } }
    public override string DogumYeri { get { return dogumyeri; } set { dogumyeri = value; } }
    public override DateTime DogumTarihi { get { return dogumtarihi; } set { dogumtarihi = value; } }
    public override string OkulAdi { get { return okuladi; } set { okuladi = value; } }
    public override int OkulNo { get { return okulnumara; } set { okulnumara = value; } }
    public override string Sinifi { get { return sinifi; } set { sinifi = value; } }
    public override void BilgileriniYazdir()
    {
        Console.WriteLine("Öğrencinin Adı: "+ ad);
        Console.WriteLine("Öğrencinin Soyadı: "+soyad);
        Console.WriteLine("Öğrencinin Doğum Yeri:" + dogumyeri);
        Console.WriteLine("Öğrencinin Doğum Tarihi: " + dogumtarihi.ToShortDateString()) ; // gün.ay.yıl formatında ekranda görünmesi için
        Console.WriteLine("Öğrencinin Okulu: "+okuladi);                                   // çünkü datetime da saat dakika ve saniye de var
        Console.WriteLine("Öğrencinin numarası: "+okulnumara);
        Console.WriteLine("Öğrencinin sınıfı: "+sinifi);
    }

}
class Surucu : Insan, IEhliyet
{
    private string ad;
    private string soyad;
    private string dogumyeri;
    private DateTime dogumtarihi;
    private string ehliyetsinifi;
    private DateTime ehliyettarihi;

    public override string Ad { get { return ad; } set { ad = value; } }
    public override string SoyAd { get { return soyad; } set { soyad = value; } }
    public override string DogumYeri { get { return dogumyeri; } set { dogumyeri = value; } }
    public override DateTime DogumTarihi
    {
        get { return dogumtarihi; }
        set { dogumtarihi = value; }
    }


    public string EhliyetSinifi { get { return ehliyetsinifi; } set { ehliyetsinifi = value; } }
    public DateTime EhliyetTarihi
    {
        get { return ehliyettarihi; }
        set { ehliyettarihi = value; }
    }
    public void BilgileriniYazdir()
    {
        Console.WriteLine("Sürücünün Adı: " + ad);
        Console.WriteLine("Sürücünün Soyadı: " + soyad);
        Console.WriteLine("Sürücünün Doğum Yeri:" + dogumyeri);
        Console.WriteLine("Sürücünün Doğum Tarihi: " + dogumtarihi.ToShortDateString()); // gün.ay.yıl formatında ekranda görünmesi için
        Console.WriteLine("Sürücünün Ehliyet Aldığı Tarih: " + ehliyettarihi.ToShortDateString()); // gün.ay.yıl formatında ekranda görünmesi için
        Console.WriteLine("Sürücünün Ehliyet Sınıfı: "+ehliyetsinifi);
    } 
}
*/
