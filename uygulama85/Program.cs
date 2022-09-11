// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] adlar = new string[] { "Ali", "Veli", "Ekrem", "Coşkun", "Yavuz" };
Array.Sort(adlar);
Array.Reverse(adlar);
foreach (var isim in adlar)
{
    Console.WriteLine(isim);
}
Console.WriteLine("Aranan Kişinin Adı Yazın");
string ara = Console.ReadLine();
int numara = Array.IndexOf(adlar, ara);
Console.WriteLine(numara);
