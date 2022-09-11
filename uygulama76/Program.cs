// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//1-100 arasında 5 ve 7 tamam bölünenlerini ekrana yazdırın.
//&& and iki tutacak || veya ikisinde biri yeterli 
// && and 
int bes, yedi;
for (int i = 0; i < 100; i++)
{
    bes = i % 5;
    yedi = i % 7;
    if (bes == 0 && yedi == 0)
    {
        Console.WriteLine("{0} Tam Bölünen", i);
    }

}
