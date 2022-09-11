// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//arda arda 10 defa iki sayı toplatın ve sonucu ekrana yazdırın
int toplam = 0;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Bir Sayı Girin");
    int sayi = int.Parse(Console.ReadLine());
    toplam = toplam + sayi;
    Console.WriteLine("{0} sayi Toplandı", i);
}
Console.WriteLine("Toplama İşlemi Sonucu:{0}", toplam);

// ödevini yaptımı yaptı ise 1 yapmadıysa 2 işarelenecek
// eğer yaptıysa teşekkür et 
//yapmadıysa 100 defa ödemi yapacağım yazsın

