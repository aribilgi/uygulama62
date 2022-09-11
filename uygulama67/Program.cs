// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mesafeyi Giriniz");
int mesafe = int.Parse(Console.ReadLine());
if (mesafe > 15)
{
    Console.WriteLine("İleri");
}
else if (mesafe <= 15)
{
    Console.WriteLine("Sağa Dön");
}
