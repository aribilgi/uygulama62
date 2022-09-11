// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


string adi = "Murat";
int sayi = 10;
double ondalik = 10.263;
float kusurat = 10.2566f;

adi = "Yasin";

//Console.Write(adi);
//Console.WriteLine(adi.GetType());
//Console.WriteLine(sayi.GetType());
//Console.WriteLine(kusurat.GetType());
//string[] kume = new string[] { "Hüseyin", "Elif", "Serkan", "Yunus" };
//Console.WriteLine(kume[0]);
//Console.WriteLine(kume[1]);
string[] sinifListesi = new string[5];
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Adınızı Girin");
    sinifListesi[i] = Console.ReadLine();
}
//Console.WriteLine(sinifListesi);
Console.WriteLine("***************************************");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(sinifListesi[i]);

}

