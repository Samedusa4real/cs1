int qiymet;
Console.WriteLine("Imtahan qiymetini daxil edin:");

qiymet = Convert.ToInt32(Console.ReadLine());


if (qiymet >= 0 && qiymet <= 100)
{
    if (qiymet >= 91)
    {
        Console.WriteLine("A");
    }
    else if (qiymet >= 81)
    {
        Console.WriteLine("B");
    }
    else if (qiymet >= 71)
    {
        Console.WriteLine("C");
    }
    else if (qiymet >= 61)
    {
        Console.WriteLine("D");
    }
    else if (qiymet >= 51)
    {
        Console.WriteLine("E");
    }
    else
    {
        Console.WriteLine("F");
    }
} else
{
    Console.WriteLine("Duzgun qiymet daxil edin.");
}