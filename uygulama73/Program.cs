// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Ödevini Yaptın 1.Evet 2.Hayır");
int odev = int.Parse(Console.ReadLine());
if (odev == 1)
{
    Console.WriteLine("Teşekkür Ederim");
}
else
{
    for (int i = 0; i < 100; i++)
    {
        Console.WriteLine("Ödevimi Yapacağım");
    }
}

