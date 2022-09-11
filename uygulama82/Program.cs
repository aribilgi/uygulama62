// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] isimler = new string[4];
string[] sicaklar = new string[4];
string[] arasicaklar = new string[4];
string[] anayemek = new string[4];
string[] tatli = new string[4];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("isiminiz");
    isimler[i] = Console.ReadLine();
    Console.WriteLine("Sıcak ne alır sınız?");
    sicaklar[i] = Console.ReadLine();
    Console.WriteLine("arasicaklar");
    arasicaklar[i] = Console.ReadLine();
    Console.WriteLine("Ana Yemek ne alır sınız?");
    anayemek[i] = Console.ReadLine();
    Console.WriteLine("Tatli ne alır sınız?");
    tatli[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Sipariş Verenin Adı:{0}", isimler[i]);
    Console.WriteLine("Sipariş Sıcaklar:{0}", sicaklar[i]);
    Console.WriteLine("Sipariş Ara Sıcaklar:{0}", arasicaklar[i]);
    Console.WriteLine("Sipariş Ara Yemek:{0}", anayemek[i]);
    Console.WriteLine("Sipariş Tatli:{0}", tatli[i]);
    Console.WriteLine("################### Siparişler ############################");
}