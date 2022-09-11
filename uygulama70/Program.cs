// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//fotokopi saysını girin  
//ekrana 1.Fotokopi çekildi yazsın
Console.WriteLine("Fotokopi Sayısını Girin");
int sayi = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayi; i++)
{
    Console.WriteLine("{0} Fotokopi Çekildi", i);
}
