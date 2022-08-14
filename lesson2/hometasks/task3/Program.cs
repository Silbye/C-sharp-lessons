Console.Clear();

Console.Write("Enter your day: ");
int day = Convert.ToInt32(Console.ReadLine());

bool weekendFinder(int day)
{
    if (day > 0 & day < 8)
    {
        if (day == 6 || day == 7)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    throw new Exception ("there is no such day");
}

bool display = weekendFinder(day);
Console.WriteLine(display);
