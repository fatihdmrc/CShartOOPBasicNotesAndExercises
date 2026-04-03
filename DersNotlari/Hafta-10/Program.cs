/* Özet Not
- Kalıtım yaptığımız üst(ana) sınıfın propertyleri ve field larına ve metotlarına erişebiliyoruz
- Üst sınıfın metotlarına alt sınıftan erişebilmek için üst sınıftaki metodu virtual olarak tanımlıyoruz
ve alt sınıfta değişiklik yapmak için override ediyoruz.
- Alt sınıfta nesne oluşturduğumuzda üst sınıfın boş olan yapıcı metodu önce çalışıyor
sonra varsa bizim alt sınıfımızın yapıcı metodu çalışıyor
- Eğer üst sınıf parametreli bir yapıcı metot ile kurulmuşsa bizde alt sınıfı oluştururken
:base(degisken) yapısını alt sınıfın yapıcı metoduna ekleyerek parametreli olarak yapıcı metodu kurmamız gerekiyor.
Bu durumda base(degisken) diyerek üst sınıfın tek parametreli yapıcı metodunu çalıştırmış oluyoruz
Sonrasında bizim alt sınıfımızın yapıcı metodu çalışıyor!
-Eğer üst sınıfın yapıcı metodunu  parametreli olarak kurduysak ve 
alt sınıfın metodunu parametresiz olarak kurmak istiyorsak o zaman üst sınıfa parametresiz yapıcı metot eklemeliyiz!

 
 */


Daire daire1 = new Daire("Kırmızı", 5);
daire1.Yazdir();
Dikdörtgen dikdörtgen1 = new Dikdörtgen(10,5, "Yeşil");
dikdörtgen1.Yazdir();
GeometrikNesne gnesne = new GeometrikNesne(); // parametresiz yapıcı metot çalışacak ve rengi siyah olarak ayarlanacak!
gnesne.Yazdir();
class GeometrikNesne
{
    /* Sorunun çözümü için 1. yöntem
    public GeometrikNesne()
    {

    }
    */
    public GeometrikNesne() // Eğer bu parametresiz yapıcı metodu kurmazsak Daire sınıfındaki sadece yarıçap parametresi alan yapıcı metot çalıışmaz hata verir!
    {
        Renk = "Siyah";
        Console.WriteLine("------------------------------------------------ ");
        Console.WriteLine("Geometrik nesne sınıfının parametresiz olan yapıcı metodu çalıştı! ");
        Console.WriteLine("------------------------------------------------ ");
    }
    public string Renk { get; set; }
    public GeometrikNesne(string renk)
    {   
        Renk = renk;
        Console.WriteLine("Geometrik nesne oluşturuldu ve rengi eklendi!");
        Console.WriteLine("---------------------------------------");
    }
    public virtual void Yazdir() // virtual yazdığımız metodu alt sınıfta güncellemek için veya değiştirmek için virtual kelimesini ekledik!
    {
        Console.WriteLine("Rengi: " + Renk);
    }
}
/* Bu şekilde alt sınıf oluşturduğumuzda hata verir.
 Bu hatayı çözmek için 2 yöntem var.
1.Yöntem: GeometrikNesne sınına parametresiz constructor kurulabilir.
2.Yöntem: Daire sınına yani alt sınıfa renk değişkenin bulunduğu bir constructor metot eklenir.
class Daire : GeometrikNesne
{
}
*/
class Daire : GeometrikNesne
{
    // 2. yöntem
    // base(renk) diyerek üst sınıftaki yani GeometrikNesne sınıfındaki renk parametresinı alan constructor çalıştırılıyor
    public Daire(double yaricap)
    {
        Console.WriteLine("Daire oluşturuldu ve yarıçapı eklendi!");
        Console.WriteLine("---------------------------------------");
        Yaricap = yaricap;
    }
    public Daire(string renk) : base(renk)
    {
        Console.WriteLine("Daire oluşturuldu ve rengi eklendi!");
        Console.WriteLine("---------------------------------------");
    }
    public Daire(string renk, double yaricap) : base(renk)
    {
        Yaricap = yaricap;
        Console.WriteLine("Daire oluşturuldu rengi ve yarıçapı eklendi!");
        Console.WriteLine("---------------------------------------");
    }

    public double Yaricap { get; set; }
    public double AlanHesapla()
    {
        return Yaricap * Yaricap * Math.PI;
    }
    public double CevreHesapla()
    {
        return 2 * Yaricap * Math.PI;
    }
    public override void Yazdir() // Burda override diyerek üst sınıftaki metodu güncelleyebiliyoruz!
    {
        Console.WriteLine("Dairenin özellikleri yazdırılıyor...");
        Console.WriteLine("Dairenin alanı: " + AlanHesapla());
        Console.WriteLine("Dairenin çevresi: " + CevreHesapla());
        Console.WriteLine("Dairenin rengi: " + Renk); // bu sınıfta Renk adı verilen bir prop yok ama üst sınıftan kalıtım yardımıyla bu özelliği kullanabiliyoruz!
    }
}

class Dikdörtgen:GeometrikNesne
{
    public Dikdörtgen(double genislik, double yukseklik,string renk)
    {
        Renk = renk;
        Yukseklik = yukseklik;
        Genislik = genislik;
        Console.WriteLine("Dikdörtgen oluşturuldu, rengi ve boyutları eklendi!");
        Console.WriteLine("---------------------------------------");
    }
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
    public double CevreHesapla()
    {
        return 2 * (Genislik + Yukseklik);
    }
    public override void Yazdir()
    {
        Console.WriteLine("Dikdörgenin özellikleri yazdırılıyor...");
        Console.WriteLine("Dikdörgenin Genişliği: " + Genislik);
        Console.WriteLine("Dikdörgenin Yüksekliği: " + Yukseklik);
        Console.WriteLine("Dikdörgenin Çevresi: " + CevreHesapla());
        Console.WriteLine("Dikdörgenin Alanı: " + AlanHesapla());
        Console.WriteLine("Dikdörtgenin Rengi: " + Renk);
    }


}

/* Kalıtım - Inheritance
// Kalıtımda üst sınıflar daha detaylı gibi düşünülebilir ama öyle değil alt sınıflar daha detaylıdır.
Insan insan1 = new Insan();
insan1.Ad = "Ornek";
insan1.Soyad = "Kullanici";
Console.WriteLine(insan1.Yazdir());
Console.WriteLine(insan1.ToString());// ToString sınıf ismini getirir

Calisan calisan1 = new Calisan();
calisan1.Ad = "Ornek";
calisan1.Soyad = "Kullanici";
calisan1.Maas = 55000;
calisan1.CalisanId = 1;
calisan1.FirmaAdi = "Ornek Firma";
Console.WriteLine(calisan1.Yazdir());
Console.WriteLine(calisan1.ToString());

class Insan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public string Yazdir()
    {
        return Ad + " " + Soyad;
    }

}
class Calisan : Insan // üst sınıf Insan , alt sınıf Calisan
{
    // burda Insan sınıfından kalıtım yaparak ad , soyad ve yazdir metodunu kullanabiliriz
    // Yani kalıtım yaptığımız sınıfın özelliklerine erişebiliriz.
    public int CalisanId { get; set; }
    public string FirmaAdi { get; set; }
    public int Maas { get; set; }

    public string Yazdir()
    {
        return Ad + " " + Soyad + " " + CalisanId + " " + Maas + " " + FirmaAdi;
    }
}
*/

/* Immutable Sınıflar ve Nesneler

// Sabit Nesneler ve sınıflar (immutable sınıf ve nesneler)
// Bizim için önemli olan ve değişmesini istemediğimiz verilerde kullanırız.
// Immutable sınıflardaki alanlar ve proplar private olarak oluşturulmalı.
// Nesne 1 defa oluşturulacağı için o nesneye oluşturulurken yapıcı metoda girilen değerler 
bir daha değişime uğramayacağı için sabit nesneler ve sınıflar diyoruz.
Ogrenci ogr1 = new Ogrenci(111,"Ornek Ogrenci");
Console.WriteLine("No: "+ogr1.getOgrenciNo());
Console.WriteLine("Adı: "+ogr1.getOgrenciadi());
Console.WriteLine("Oluşturulma Tarihi: "+ogr1.getOlusturmaTarihi());
class Ogrenci
{
    private int ogrencino;
    private string ogrenciadi;
    private DateTime olusturulmaTarihi;

    public Ogrenci(int ogrNo, string ogrAdi)
    {
        ogrencino = ogrNo;
        ogrenciadi = ogrAdi;
        olusturulmaTarihi = DateTime.Now;
    }
    public int getOgrenciNo()
    {
        return ogrencino;
    }
    public string getOgrenciadi()
    {
        return ogrenciadi;
    }
    public DateTime getOlusturmaTarihi()
    {
        return olusturulmaTarihi;
    }
}
*/

/* Nesneleri Dizi İle Kullanmak
Cember[] dizi = new Cember[10]; // 10 adet Cember nesnesinden oluşan dizi oluşturduk
for(int i=0; i<dizi.Length; i++)
{
    dizi[i]= new Cember(i+1);
}
// Eğer diziye atama yapmadan ve nesneleri oluşturmadan nesneleri ekranda yazdırmak isteseydik
// ekranda null gelecekti yani hiçbişey gelmeyecekti bir boş satır yapacaktı.
Console.WriteLine(dizi[6].Yaricap);
Console.WriteLine(dizi[7].AlanHesapla());
Console.WriteLine(dizi[8].CevreHesapla());
// Eğer dizi[15] yapsaydık yani dizi boyutundan büyük eleman isteseydik o zaman IndexOutOfRangeException hatasını alırdık.


public class Cember
{
    public Cember(double yaricap)
    {
        Yaricap = yaricap;
    }
    public double Yaricap
    {
        get; set;
    }
    public double AlanHesapla()
    {
        return Math.PI * Yaricap * Yaricap;
    }
    public double CevreHesapla()
    {
        return 2 * Math.PI * Yaricap;
    }
}
*/
