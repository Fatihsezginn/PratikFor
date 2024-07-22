
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Keendime inanıyorum ben bu yazılım işini hallederim!");
}
   






for(int i = 1; i < 20; i++)
{
    Console.WriteLine(i);
}






for(int i = 0;i < 20; i+=2)
{
    Console.WriteLine(i);
}





int toplam = 0;
for (int i = 50; i < 150; i++)
{
    toplam += i;
}
Console.WriteLine($"50 ile 150 arasındaki toplam sayı: {toplam}");




int tek = 0;
int cift = 0;

for (int i = 1; i <= 120; i++)

{   
    if (i % 2 == 0)

    {
        cift += i;
    }

    else
    {
        tek += i;
    }
}
Console.WriteLine("Tek sayıların toplamı = " + tek);
Console.WriteLine("Cift sayıların toplamı = " + cift);