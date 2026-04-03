
/* Verilen sayının rakamları toplamını bulmak
static int RakamToplam(int sayi)
{
    int bölüm = 1;
    int basamaktoplam = 0;
    while (sayi > 0)
    {
        int kalan = sayi % 10;
        bölüm = sayi / 10;
        sayi = bölüm;
        basamaktoplam = basamaktoplam + kalan;
    }
    return basamaktoplam;
}

Console.WriteLine("Lütfen bir sayı giriniz:: ");
int girilensayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(girilensayi + "'nın rakamları toplamı: " + RakamToplam(girilensayi));
Console.WriteLine("--------------------------------------------------------------------");
*/


/* Fahrenheit 'ı Celsius'a Çevirmek
// C= (F-32)/1.8
static double CelsiusCevir(double fahrenheit)
{
    double celsiuscevrilmis = (fahrenheit - 32) / 1.8;
    return celsiuscevrilmis;
}

    Console.WriteLine("Lütfen fahrenheit değerini giriniz: ");
    double girilenFahrenheit = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(girilenFahrenheit + " fahrenheit' ın  celsius karşılığı: " + CelsiusCevir(girilenFahrenheit)) ;

*/

/* Celsius'u Fahrenheit' Çevirmek
static double FahrenheitCevir(double celsius)
{
    double cevrim = (celsius * 1.8) + 32;
    return cevrim;
}

    Console.Write("Lütfen celsius değerini giriniz: ");
    double girilencelsius = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine(girilencelsius+" celsius'un fahrenheit karşılığı: "+FahrenheitCevir(girilencelsius));

*/


/*Mükemmel sayı mı ? Kontrol
static bool MukemmelSayiMi(int sayi)
{
    int bolenlerinintoplami = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            bolenlerinintoplami = bolenlerinintoplami + i;
        }
    }
    if (bolenlerinintoplami == sayi)
    {
        return true;

    }
    else
    {
        return false;
    }
}
while (true)
{
    Console.WriteLine("Lütfen sayı giriniz: ");
    int girilensayi = Convert.ToInt32(Console.ReadLine());
    if (MukemmelSayiMi(girilensayi) == true)
    {
        Console.WriteLine("Girilen sayı mükemmel sayıdır.");
    }
    else
    {
        Console.WriteLine("Girilen sayı mükemmel değildir.");
    }
}
*/




/*Mükemmel sayıları yazdırma
int sayi = 1;
while (sayi < 1000000000)
{
    int bolenlerintoplami = 0;
    for (int i = 1; i < sayi; i++)
    {
        if (sayi % i == 0)
        {
            bolenlerintoplami = bolenlerintoplami + i;
        }
    }
    if (bolenlerintoplami == sayi)
    {
        Console.WriteLine(sayi);
    }
    sayi++;
}
*/



/* ARRAY (DİZİLER)
// Farklı dizi tanımlama yolları 
int[] dizi1 = new int[4]; //1. Yöntem
int[] dizi2 = { 1, 3, 5, 7 }; // 2.yöntem


string[] dizi3; // 3. yöntem
dizi3 = new string[3] { "1", "2", "3" };

string[] dizi4 = new string[] { "15", "20", "25" }; //4.yöntem
*/

/* dizinin elemanlarına döngü ile atama yapmak
int toplam = 0;
int[] dizi = new int[10];
for(int i=0; i<dizi.Length; i++)
{
    dizi[i] = i * 10;
    Console.WriteLine("dizi["+i+"] " + dizi[i]);
    toplam = (i * 10) + toplam;
}
Console.WriteLine(toplam);
*/


/*Foreach kullanımı ve dizi metotları
string[] dizi = new string[] { "BMW", "MERCEDES", "VOLVO", "AUDİ", "RENAULT", "TOYOTA", "KİA", "MAZDA" };
Array.Sort(dizi); // a'dan z'ye veya küçükten büyüğe sıralar
foreach (string x in dizi)
{
    Console.WriteLine(x);
}
Console.WriteLine("-----------------------------------");
int[] dizi0 = new int[] { 1, 5, 48, 24, 57, 41, 55, 97, 17, 30 };
Array.Sort(dizi0); // diziyi sıralar
foreach (int x in dizi0)
{
    Console.WriteLine(x);
}
Console.WriteLine("Maks değer: "+ dizi0.Max());// maks değeri getirir , sıralanmış değerde en son değer gelir
Console.WriteLine("Min değer: "+dizi0.Min()); //min değeri getirir , sıralanmış değerde ilk değer gelir
Console.WriteLine("Toplamları: "+dizi0.Sum()); // dizinin içindeki değerlerin toplamı
Console.WriteLine("Kaç terim var: "+dizi0.Count());
*/

/* Çok boyutlu diziler
int[,] dizi0 = { {15,25,60 },{ 45,48,19 } };
foreach(int x in dizi0)
{
    Console.WriteLine(x);
}
*/

// Değişken ve Dizi Elemanlarının Metottaki Durumu
static void DiziDegistir(int[] dizi)
{
    for(int i=0; i<dizi.Length; i++)
    {
        dizi[i] = (i + 1) * (i + 2);
    }
}
static int DegiskenDegistir(int x)
{
    x = 100;
    return x;
}

int toplam = 0;
Console.WriteLine("toplam değişkeninin ilk değeri " + toplam);
Console.WriteLine("toplam değişkeninin metotta işleme uğramış değeri "+DegiskenDegistir(toplam));
Console.WriteLine("toplam değişkeninin metot işleminden sonraki değeri "+toplam);

int[] dizi0 = { 0, 2, 4, 6, 8, 15 };
foreach (int i in dizi0)
{
    Console.WriteLine("(Dizinin ilk değerleri) "+i);
}
DiziDegistir(dizi0);

foreach (int i in dizi0)
{
    Console.WriteLine("(Dizinin metottaki işlemden sonraki değerleri )" + i);
}
//Yani metotta değişkene yaptığımız işlemler en baştaki atamaya geri dönüyor
// Fakat metotta diziye bir işlem yapmışsak o halen geçerli kalıyor. İlk atandığı değere dönmüyor.

Console.ReadKey();

