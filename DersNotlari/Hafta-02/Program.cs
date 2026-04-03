

/*iki sayı arasındaki sayıların toplamı --döngü ile
int toplam = 0;
for(int i=1; i <= 10; i++)
{
    toplam=toplam+i;
}
Console.WriteLine("1 ile 10 arasındaki sayıların toplamı"+toplam);

*/


/* iki sayı arasındaki sayıların toplamı-- metot ile
static int ToplaMetot(int a,int b)
{
    int toplam = 0;
    for (int i = a; i <= b; i++)
    {
        toplam = toplam + i;
    }
    return toplam;
}
Console.WriteLine("İki sayı arasındaki toplam: " + ToplaMetot(1, 10));
*/


/* iki sayının toplamını veren metot
static int ToplaMetodu(int a, int b)
{
    return a + b;
}
Console.WriteLine("İki sayının toplamı: " + ToplaMetodu(10, 25));
*/


/* İki sayıyı çarpma metodu
static int CarpimMetot(int a, int b)
{
    return a * b;
}
Console.WriteLine("11 ile 12 nin çarpımı: " + CarpimMetot(11,12));
*/

/* En büyük sayıyı bulan metot
static int Max(int sayi1, int sayi2)
{
    if (sayi1 > sayi2)
    {
        return sayi1;
    }
    else if (sayi2>sayi1 )
    {
        return sayi2;
    }
    else
    {
        return 0;
    }
}
Console.WriteLine("15, 20, 5 den büyük olanı: "+Max(Max(15,20),5)+"'dir.");
*/


/*  Not yazdırma
static void NotYazdir(double not)
{
    if(not>=80 && not <= 100)
    {
        Console.Write("A");
    }
    else if (not >= 60)
    {
        Console.Write("B");
    }
    else if(not >= 55)
    {
        Console.Write("C");
    }
    else if (not >= 50)
    {
        Console.Write("D");
    }
    else
    {
        Console.Write("F (kaldı)");
    }
}
Console.Write("Lütfen ortalama notunuzu giriniz: ");
double girilennot = Convert.ToDouble(Console.ReadLine());
Console.Write("Notunuzun harf karşılığı: ");
NotYazdir(girilennot);
*/


/*Artırma Metodu
int x = 10;
Console.WriteLine("x in değişken içinde tanımlanmış başlangıç değeri: "+x);
static void Artir(int artirilacakSayi)
{
    artirilacakSayi++;
    Console.WriteLine("x'in metot içinde artırılmış değeri: " + artirilacakSayi);
}
Artir(x);
Console.WriteLine("x'in metotta artırıldıktan sonraki hali: "+x);
// Not: Değişken metot içinde işleme uğradığında o değer metot
// içinde işlem görmüş olur. İşlem görmüş hali metot içinde geçerlidir.
// Fakat metot dışında ilk atanmış değerine geri döner
*/


/*EBOB Metodu Farklı Yöntem
static int EbobBul(int sayi1, int sayi2)
{
    int ebob = 0;
    for (int i = 1; i <= sayi1; i++)
    {
        if (sayi1 % i == 0 && sayi2 % i == 0)
        {
            ebob = i;
        }
    }
    return ebob;
}
Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sayıların ebobu: " + EbobBul(a, b));
*/

//EBOB Metodu 
static int EbobBul(int sayi1, int sayi2)
{
    int bolensayi = 1;
    int ebob = 0;
    while (bolensayi <= sayi1 && bolensayi <= sayi2)
    {
        if (sayi1 % bolensayi == 0 && sayi2 % bolensayi == 0)
        {
            ebob = bolensayi;
        }
        bolensayi++;
    }
    if (ebob == 1)
    {
        Console.WriteLine("Bu sayılar aralarında asaldır!");
    }
    return ebob;
}
Console.WriteLine("Lütfen ilk sayıyı giriniz: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a+" ile "+b+" nin ebobu "+EbobBul(a, b));

Console.ReadKey();
