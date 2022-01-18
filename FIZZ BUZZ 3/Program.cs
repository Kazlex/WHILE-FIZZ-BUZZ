int i = 1;
while ( i <= 100 )
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i + (" FIZZ BUZZ"));
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine(i + (" FIZZ"));
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine(i + (" BUZZ"));
    }
    else
    {
        Console.WriteLine(i);
    }
    i++;
}
