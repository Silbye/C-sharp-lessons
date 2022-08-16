Console.Clear();
Console.Write("Enter your number: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Count = 0;

int digitsAmountFinder(int Number)
{
    if (Number == 0)
    {
        Count = 1;
    }
    else
    {
        while (Number > 0)
        {
            Number /= 10;
            Count++;
        }
    }
    return Count;
}

int display = digitsAmountFinder(Number);
Console.WriteLine(display);