//ArrayList ile Tekrar Eden Sayıları Ekrana Yazdırmayan Uygulama
using System.Collections;
ArrayList liste = new ArrayList();
Console.WriteLine("Sayı Giriniz: (ÇIKIŞ İÇİN 0) ");
while (true)
{
    int sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi == 0)
    {
        break;
    }
    if (liste.Contains(sayi) == false && sayi%2==0)
    {
        liste.Add(sayi);
    }
    else
    {
        Console.WriteLine("Sayı listede var veya çift değil lütfen başka bir sayı girin");
    }
}
foreach (int i in liste)
{
    Console.Write(i + " ");
}


/* ArrayList
//Arraylist array den farklı olarak eleman eklenebilir veya çıkarılabilir.
// Daha dinamiktir.
using System.Collections; // ArrayList kullanmamız için
using System.ComponentModel;

ArrayList sehirlerlistesi = new ArrayList();
sehirlerlistesi.Add("Bandırma");// Listeye eleman ekleme
sehirlerlistesi.Add("İstanbul");
sehirlerlistesi.Add("Ankara");
sehirlerlistesi.Add("Yozgat");
sehirlerlistesi.Add("Çorum");
sehirlerlistesi.Add("Mersin");

Console.WriteLine("Listedeki eleman sayısı: "+sehirlerlistesi.Count); // ArrayListteki eleman sayısını yazdırıyoruz
Console.WriteLine("Listede Yozgat var mı? "+sehirlerlistesi.Contains("Yozgat")); // ArrayListteki bir elemanı aramak için  (küçük-büyük harf duyarlılığı var) // True Yada False döner
Console.WriteLine("Listenin Capacity: "+sehirlerlistesi.Capacity);
sehirlerlistesi.Remove("Çorum"); // Çorum Elemanını sildik
Console.WriteLine("Çorum elemanı listeden silindi");
Console.WriteLine("Çorum silindikten sonra Listedeki eleman sayısı: " + sehirlerlistesi.Count);
Console.WriteLine("Çorum silindikten sonra Listedeki Capacity: " + sehirlerlistesi.Capacity);
//sehirlerlistesi.RemoveAt(0) --> 0. indexdekini siler --> yani Bandırma yı siler.
// Kapasitesi 4,8,16,32,64 olarak ilerliyor
for (int i=0; i<sehirlerlistesi.Count; i++)
{
    Console.WriteLine(sehirlerlistesi[i]);
}
*/


/* Polimorfizm

// Nesneleri oluşturup metodlarını çağırdık
//Hayvan kedi1 = new Kedi("Tarçın"); // Nesneyi bu şekilde de oluşturabiliriz. Üst alt sınıf ilişkisi olduğu için. Üst sınıf ilk yazılır.
//Hayvan kopek1 = new Kopek("Karabaş");
//Hayvan at1 = new At("Beyaz Saray");
//Console.WriteLine(kedi1.konus());
//Console.WriteLine(kopek1.konus());
//Console.WriteLine(at1.konus());

static void konustur(Hayvan hayvan) // Hayvan sınıfının hayvan nesnesi ile çalışan bir metot yaptık
{
    Console.WriteLine(hayvan.konus());//hayvan nesnesini konuşturduk
}
//Bu şekilde de konustur static metodunu kullanabiliriz
//Hayvan kedi1 = new Kedi("Bal");
//konustur(kedi1);

konustur(new Kedi("Bal")); // Kedi sınıfından yeni bir nesne oluşturduk  ve static olan konuştur metodu ile konuşturduk.
konustur(new Kopek("Karabaş"));
konustur(new At("Beyaz Saray"));
public class Hayvan
{
    private string isim;
    public Hayvan(string isim)
    {
        this.isim = isim;
    }
    public virtual string konus() // oveerride edeceğimiz metod
    {
        return getIsim() +" konuşuyor";
    }
    public string getIsim()
    {
        return isim;
    }
    public void setIsim(string isim)
    {
        this.isim = isim;
    }
}
public class Kedi : Hayvan
{
    public Kedi(string isim) : base(isim) { }
    public override string konus()
    {
        return this.getIsim() + " Miyavlar";
    }
}
public class Kopek : Hayvan
{
    public Kopek(string isim) : base(isim) { }
    public override string konus()
    {
        return this.getIsim() + " Havlar";
    }
}
public class At : Hayvan
{
    public At(string isim) : base(isim) { }
    public override string konus()
    {
        return base.konus();
    }
}
*/

/* Zincirleme Kalıtım Yapmak ve Metodu Override Etmek
Kisi kisi1 = new Kisi();
Console.WriteLine(kisi1.ToString());
Ogrenci ogrenci1 = new Ogrenci();
Console.WriteLine(ogrenci1.ToString());
MezunOgrenci mezunogrenci1 = new MezunOgrenci();
Console.WriteLine(mezunogrenci1.ToString());

// MezunOgrenci sınıfında ToString metodu yok ve override edilmedi.
// Ama MezunOgrenci sınıfı Ogrenci sınıfının alt sınıfı olduğu için Ogrenci sınıfındaki override edilmiş olan ToString() metodu çağırılmış oldu.
class Kisi:Object // Object sınıfından türeyen bir Kisi sınıfı oluşturdum
{
    public override string ToString() // Object sınıfındaki ToString Metodunu override ettim
    {
        return "Kisi sınıfı";
    }
}
class Ogrenci:Kisi
{
    public override string ToString()  // Kisi sınıfındaki metodu override ettim
    {
        return "Ogrenci sınıfı";
    }
}
class MezunOgrenci:Ogrenci 
{
    
}
*/


/* Kalıtım İle Override
BB bb = new BB();
bb.p(1.2);
AA aa = new AA();
aa.p(1.2);

class BB
{
    public virtual void p(double i)
    {
        Console.WriteLine("BB-->"+i);
    }
}

// -Üst sınıftaki metodu virtual olarak oluşturuyoruz.
// -Alt sınıftaki metod da ismi , geriye değer döndürme tipi ve aldığı değişken de aynı olmalı
// ama alt sınıfta override kelimesini ekliyoruz istersek güncelliyoruz istemezsek base kullanarak
// üst sınıftaki metodu aynen çalıştırıyoruz

class AA:BB
{
    public override void p(double i)
    {
        //  base.p(i); eğer metodu güncellemek istemiyorsak bu şekilde bırakmalıyız.
        //  Üst sınıftaki metod aynen çalışacaktır.
        Console.WriteLine("AA-->"+i);
    }
}
*/


/*Kalıtım ile Overload
A a = new A();
a.p(10);
a.p(11.2); // A alt sınıfından ürettiğimiz nesne ile B sınıfındaki metodu overload şeklinde kullanabiliyoruz
class B
{
    public void p(double i)
    {
        Console.WriteLine("i :"+i);
    }

}
class A:B
{
    public void p (int i)
    {
        Console.WriteLine("i: " + (i * 2));
    }
}
*/