void weekendFinder()
{
    Console.Clear();

    Console.Write("Enter your day: ");
    int day = Convert.ToInt32(Console.ReadLine());

    if (day > 0 & day < 8)
    {
        if (day == 6 || day == 7)
        {
            Console.WriteLine("Your day is weekend!");
        }
        else
        {
            Console.WriteLine("Your day is NOT weekend!");
        }
    }
    else
    {
        Console.WriteLine("There is no such day in the week!");
    }
}
weekendFinder();
