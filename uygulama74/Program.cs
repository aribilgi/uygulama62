// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Threading;
Console.WriteLine("Kronometre Bitiş Sayısını Girin");
int sayi = int.Parse(Console.ReadLine());
for (int i = 0; i < sayi; i++)
{
    Console.Write(i);

    Thread.Sleep(1000);
    Console.Clear();
}