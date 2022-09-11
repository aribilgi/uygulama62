// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//1-100 arasındak çift sayıları toplayın  sayi%2==0
int toplam = 0;
for (int i = 0; i < 100; i++)
{
    if (i % 2 == 0)
    {
        toplam = toplam + i;
        Console.WriteLine("{0}Tam Bölündü", i);

    }
}
Console.WriteLine("Toplam Rakam{0}", toplam);
