//Interface soyutlama yapmak için kullanılır.
// İçinde sadece metotlar ve proplar bulunur. Bu metotlar sadece tanımlanır . Metotların içi alt sınıflarda doldurulur
// Bir interface tanımlarken başına büyük I ile başlanır --> best practice
// Interface'lerden nesne oluşturulmaz
// tüm interface ve üyeleri abstract ve public'tir
// Bir sınıf birden fazla interface'i kalıtım yapabilir

// Nesneleri oluşturuyoruz ve sınıflardaki metotları çağırıyoruz
Tavuk tavuk1 = new Tavuk();
Console.WriteLine("Tavuk nasıl yenir? " + tavuk1.NasilYenir());
Console.WriteLine("Tavuk nasıl ses çıkarır? " + tavuk1.Ses());
Kaplan kaplan1 = new Kaplan();
Console.WriteLine("Kaplan nasıl ses çıkarır? " + kaplan1.Ses());
Elma elma1 = new Elma();
Console.WriteLine("Elma nasıl yenir? " + elma1.NasilYenir());
Portakal portakal1 = new Portakal();
Console.WriteLine("Portakal nasıl yenir? " + portakal1.NasilYenir());

interface IYenilebilir // IYenilebilir adında bir interface oluşturduk
{
    string NasilYenir(); // interface içinde tanımladığımız metotlar interface'in kalıtım yapıldığı 
}                       // tüm sınıflarda tekrardan oluşturulmalıdır.
                        // oluştururken metodu override etmemize gerek yok
                        // direk erisim_belirteci donus_tipi metod_ismi(varsa_parametre){} olarak metod alt sınıfta oluşturulur
public abstract class Hayvan // Abstract olan Hayvan sınıfını oluşturduk
{
    public abstract string Ses(); // bir tane abstract metot mecburen olmak zorunda!
                                  // abstract ses metodunu tanımladık 
                                  // ancak metodun gövdesini oluşturmadık sadece tanımladık!
}
class Tavuk : Hayvan, IYenilebilir // Hayvan ve IYenilebilir sınının alt sınıfı olacak şekilde Tavuk sınıfını oluşturduk
{
    public override string Ses() // Abstract olan Hayvan sınıfındaki ses metodunu override ettik
    {
        return "Gıt Gıt Gıdaak , Yumurtam Sıcaaaak!";
    }
    public string NasilYenir() // IYenilebilir interface'inde tanımlamış olduğumuz NasilYenir metodunun gövdesini oluşturduk
    {
        return "Haşlayarak veya Kızartarak yenir. Pişmiş yenir!";
    }

}
class Kaplan : Hayvan // Hayvan sınıfının alt sınıfı Kaplan sınıfını oluşturduk
{
    public override string Ses() // Abstract olan Hayvan sınıfının alt sınıfı olduğu için ses metodunu override ettik
    {
        return "ROAAAAAAR!";
    }
}
abstract class Meyve : IYenilebilir // Meyve adında bir abstract class oluşturduk ve IYenilebilir interface'inden kalıtım aldık.
{
    public abstract string NasilYenir(); // abstract bir sınıf olduğu için abstract metodumuzu oluşturduk
    // NasilYenir() metodu IYenilebilir interface'inde tanımlandığı için mecburen bu sınıfta oluşturmamız gerekiyordu
}
class Elma : Meyve // Üst sınıf yani Meyve sınıfı IYenilebilir kalıtım aldığı için tekrar yazmadık
{
    public override string NasilYenir() // Meyve sınıfındaki abstract metodu override ettik
    {
        return "Kabuğunu soyarak yenir";
    }
}
class Portakal:Meyve
{
    public override string NasilYenir() /// Meyve sınıfındaki abstract metodu override ettik
    {
        return "Kabuğunu soyarak yenir!";
    }
}



/* Abstract Classlar

// Abstract Classlar - Abstract demek soyutlama demek
// c# da soyutlamayı abstract ve interface sınıflar sağlıyor
// abstract sınıflarda standart olarak bir tane de abstract metod bulunur
// abstract sınıflarda tanımlanan abstract metodlar , alt sınıflarda mutlaka override edilmelidir.
// abstract sınıflardan nesne oluşturulamaz
// Genelde base(ana) sınıf olarak kullanılır
// yapıcı metot bulundurabilir 
// static olarak tanımlanamaz!
// bir sınıf sadece bir abstract sınıfı kalıtım yapabilir

// Abstract sınıflarda belirli özellikler ve metotlar tanımlayıp bu abstract sınıftan 
// türettiğimiz sınıflar ile bu metodların içini dolduracağız temel mantığı bu şekilde
// genel bir kavramın özellikleri ve metodlarını oluşturup alt sınıflarda bunları dolduruyoruz
// ama bunların doldurulması zorunlu!

Kare k1 = new Kare("Kare1", 5);
Daire d1 = new Daire("Daire1", 3);

k1.AlanHesapla();
k1.CevreHesapla();
d1.AlanHesapla();
d1.CevreHesapla();

public abstract class Sekil
{
    private string isim;
    protected Sekil(string isim) // private olan isim field'ından oluştuğu için yapıcı metotun erişim belirteci protected olarak oluşturuldu!
    {
        this.isim = isim;
    }
    public void isimYazdir()
    {
        Console.WriteLine(isim);
    }
    public abstract void AlanHesapla(); // abstract olan metod. Alt sınıfta override edilecek!
    public string GetIsim()
    {
        return isim;
    }
    public void SetIsim(string isim)
    {
        this.isim = isim;
    }
}
public class Kare : Sekil
{
    private int kenar;
    public Kare(string isim, int kenar) : base(isim)
    {
        this.kenar = kenar;
    }
    public override void AlanHesapla()
    {
        Console.WriteLine(GetIsim() + " alanı: " + (kenar * kenar));
    }
    public void CevreHesapla()
    {
        Console.WriteLine(GetIsim() + " çevresi: " + (4 * kenar));
    }

}
public class Daire : Sekil
{
    private int yaricap;
    public Daire(string isim, int yaricap) : base(isim)
    {
        this.yaricap = yaricap;
    }
    public override void AlanHesapla()
    {
        Console.WriteLine(GetIsim() + " alanı: " + (Math.PI * yaricap * yaricap));
    }
    public void CevreHesapla()
    {
        Console.WriteLine(GetIsim() + " çevresi: " + (2 * Math.PI * yaricap));
    }
}
*/
