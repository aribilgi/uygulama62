// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir Sayı Girin");
int sayi1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Bir Sayı Girin");
int sayi2 = Convert.ToInt16(Console.ReadLine());
if (sayi1 > sayi2)
{
    //Evet yani koşul uyuyorsa
    Console.WriteLine("Sayi1 Büyüktür");
}
else if (sayi1 == sayi2)
{ Console.WriteLine("İki Sayi Birbirine Eşittir"); }
else
{
    Console.WriteLine("Sayi2 Büyüktür");
}