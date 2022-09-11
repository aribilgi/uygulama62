// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
string[] yemekler = { "Çorba", "Tatlı", "Köfte", "Salata" };
string[] fiyatlar = { "30", "15", "25", "15" };
int[] odeme = new int[2];
int toplam = 0;
Console.WriteLine("Yemek Listesi");
Console.WriteLine("****************************");
for (int i = 0; i < yemekler.Length; i++)
{
    Console.WriteLine("{0}..{1}", i, yemekler[i]);
}
for (int i = 0; i < odeme.Length; i++)
{
    Console.WriteLine("Yemek Seçiniz");
    Console.WriteLine("****************************");
    int secim = int.Parse(Console.ReadLine());
    // Console.WriteLine("Seçilen Yemek Ücreti:{0}", fiyatlar[secim]);
    odeme[i] = int.Parse(fiyatlar[secim]);
}
foreach (var item in odeme)
{
    Console.WriteLine("Seçim Yapılan Yemek Fiyatları{0}", item);
    toplam = toplam + item;
}
Console.WriteLine($"........{toplam} TL Ödenecek Tutar..........");

