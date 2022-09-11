// See https://aka.ms/new-console-template for more information
using System.Threading;

Console.WriteLine("Kaçıncı Kata Çıkmak İstiyorsunuz");
int kat = int.Parse(Console.ReadLine());
if (kat == 5)
{
    Console.WriteLine("Beşinci Katta Çıkamazsınız");

}
else
{
    for (int i = 1; i <= kat; i++)
    {
        Console.WriteLine("{0}.Kattanız", i);
        Thread.Sleep(1000);
    }
    Console.WriteLine("İnebilirsiniz");
}
