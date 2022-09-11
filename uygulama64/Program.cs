// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir Sayi Girin");
int sayi = Convert.ToInt16(Console.ReadLine());
if (sayi > 0)
{
    Console.WriteLine("Sayi Pozitiftir");
}
else if (sayi < 0)
{
    Console.WriteLine("Sayi Negatiftir");
}
else if (sayi == 0)
{
    Console.WriteLine("Sayi Sıfırda Denktir");
}
else
{
    Console.WriteLine("Bitir");
}