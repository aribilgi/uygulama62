// See https://aka.ms/new-console-template for more information
string guc;
Console.WriteLine("Gücü Açmak için 1 Kapatmak için 2 Seçiniz");
guc = Console.ReadLine();
if (guc == "1")
{
    //eger gucu bir denkse guç açık demek
    Console.WriteLine("İstenilen Sıcaklığı Girin:");
    // readline tamamen string veri döndürür
    int istenilen = Convert.ToInt16(Console.ReadLine());
    //eger gucu bir denkse guç açık demek
    Console.WriteLine("Güncel Sıcaklığı Girin:");
    // readline tamamen string veri döndürür
    int guncel = Convert.ToInt16(Console.ReadLine());
    if (guncel < istenilen)
    {
        Console.WriteLine("Isıtıcıyı Aç");
    }
    else
    {
        Console.WriteLine("Isıtıcı Kapat");
    }
}
else
{
    Console.WriteLine("Güç Kapalı");
}
