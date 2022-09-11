// See https://aka.ms/new-console-template for more information
string[] kul = { "Ahmet", "Mehmet", "Hasan", "Hüseyin" };
string[] sifre = { "123", "456", "789", "910" };
Console.WriteLine("Kullanıcını Girin");
string kulum = Console.ReadLine();
Console.WriteLine("Şife Girin");
string sifrem = Console.ReadLine();
int dogru = Array.IndexOf(kul, kulum);
int dogru1 = Array.IndexOf(sifre, sifrem);
if (dogru == -1 && dogru1 == -1)
{
    Console.WriteLine("Giremezsiniz");
}
else
{
    Console.WriteLine("Girebilirsiniz");
}
