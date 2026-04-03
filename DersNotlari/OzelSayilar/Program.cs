Console.WriteLine("Ozel sayilar ornekleri");
Console.WriteLine($"121 palindrom mu? {PalindromSayiMi(121)}");
Console.WriteLine($"153 Armstrong mu? {ArmstrongSayiMi(153)}");
Console.WriteLine($"18 Harshad mi? {HarshadSayisiMi(18)}");
Console.WriteLine($"12 Tau mu? {TauSayisiMi(12)}");

static bool PalindromSayiMi(int sayi)
{
    int orijinalSayi = sayi;
    int tersSayi = 0;

    while (sayi > 0)
    {
        int basamak = sayi % 10;
        tersSayi = (tersSayi * 10) + basamak;
        sayi /= 10;
    }

    return orijinalSayi == tersSayi;
}

static bool ArmstrongSayiMi(int sayi)
{
    int orijinalSayi = sayi;
    int basamakSayisi = sayi.ToString().Length;
    int toplam = 0;

    while (sayi > 0)
    {
        int basamak = sayi % 10;
        toplam += (int)Math.Pow(basamak, basamakSayisi);
        sayi /= 10;
    }

    return orijinalSayi == toplam;
}

static bool HarshadSayisiMi(int sayi)
{
    int toplam = 0;
    int geciciSayi = sayi;

    while (geciciSayi > 0)
    {
        toplam += geciciSayi % 10;
        geciciSayi /= 10;
    }

    return toplam != 0 && sayi % toplam == 0;
}

static bool TauSayisiMi(int sayi)
{
    int pozitifBolenAdedi = 0;

    for (int i = 1; i <= sayi; i++)
    {
        if (sayi % i == 0)
        {
            pozitifBolenAdedi++;
        }
    }

    return pozitifBolenAdedi != 0 && sayi % pozitifBolenAdedi == 0;
}

/* Palindrom sayi yazdirma
int sayi = 1;
while (sayi < 1000000)
{
    static int BasamakSayisiDondur(int sayi)
    {
        int x = 0;
        while (sayi > 0)
        {
            sayi /= 10;
            x++;
        }
        return x;
    }

    int[] basamaklar = new int[BasamakSayisiDondur(sayi)];

    int i = BasamakSayisiDondur(sayi) - 1;
    int x = sayi;
    while (x > 0)
    {
        int basamak = x % 10;
        basamaklar[i] = basamak;
        x /= 10;
        i--;
    }

    int q = 0;
    int t = BasamakSayisiDondur(sayi) - 1;
    while (true)
    {
        if (t > 0 && basamaklar[q] == basamaklar[t])
        {
            q++;
            t--;
        }
        else
        {
            break;
        }

        if (q == t)
        {
            Console.WriteLine("Sayi palindromdur. " + sayi);
            break;
        }

        if (q > t && q - t == 1)
        {
            Console.WriteLine("Sayi palindromdur. " + sayi);
            break;
        }
    }
    sayi++;
}
*/
