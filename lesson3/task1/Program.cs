Console.Clear();
Console.Write("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int result = findGraphQuarter(x, y);
Console.WriteLine("Your quarter is - " + result);

int findGraphQuarter(int x, int y)
{
    if (x > 0)
    {
        if (y > 0)
        {
            return 1;
        }
        if (y < 0)
        {
            return 4;
        }
    }
    if (x < 0)
    {
        if (y > 0)
        {
            return 2;
        }
        if (y < 0)
        {
            return 3;
        }
    }
    throw new Exception("Numbers cannot be 0");
}