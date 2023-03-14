int eded2 = int.Parse(Console.ReadLine());
int ededcopy2 = eded2;
int mertebesayi2 = 0;
while (eded2 > 0)
{
    eded2 /= 10;
    mertebesayi2++;
}
if (mertebesayi2 % 2 == 0)
{
    int quvvetustu2 = 1;
    for (int i = 0; i < mertebesayi2 / 2; i++)
    {
        quvvetustu2 *= 10;
    }
    //2456 4%2=2
    int soldakieded2 = ededcopy2 / quvvetustu2;//2456/100=24
    int sagdakieded2 = ededcopy2 % quvvetustu2;
    int yekuneded = soldakieded2 * (quvvetustu2 * 10) + 5 * quvvetustu2 + sagdakieded2;
    Console.WriteLine(yekuneded);
}
else
{
    if (mertebesayi2 > 1)
    {
        int quvvetustu2tek = 1;
        for (int i = 0; i < (mertebesayi2 + 1) / 2; i++)
        {
            quvvetustu2tek *= 10;
        }
        //245
        int soldakiededtek = ededcopy2 / quvvetustu2tek;//2
        int sagdakieded = ededcopy2 % quvvetustu2tek;//45
        int yekunededtek = soldakiededtek * (quvvetustu2tek * 10) + 5 * quvvetustu2tek + sagdakieded;
        Console.WriteLine(yekunededtek);
    }
    else
    {
        Console.WriteLine("Ededinizin mertebe sayi 3-den az oldugu ucun bu serti odemir");
    }
}
