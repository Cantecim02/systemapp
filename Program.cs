using System;

class Program
{
    static void Main()
    {
    Giriş:
        string dogruKullanici = "admin";
        string dogruSifre = "123456";

        Console.Write("Kullanıcı adınızı girin: ");
        string kullaniciAdi = Console.ReadLine();

        Console.Write("Şifrenizi girin: ");
        string sifre = Console.ReadLine();

        if (kullaniciAdi == dogruKullanici && sifre == dogruSifre)
        {
            Console.WriteLine("\nGiriş başarılı!");
        }
        else
        {
            Console.WriteLine("\nLütfen bilgilerinizi kontrol ediniz.\n");
            goto Giriş;
        }
    }
}

