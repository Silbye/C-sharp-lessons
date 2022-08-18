Console.Clear();
Console.Write("Enter your number: ");
int Number = Convert.ToInt32(Console.ReadLine());

bool checkPalindrom(int Number)
{
    string numberReverse = Number.ToString();
    if (Number >= 10000 && Number < 100000)
    {
        if (numberReverse.Reverse().SequenceEqual(numberReverse))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    throw new Exception ("Number is not 5 digits");
}

bool display = checkPalindrom(Number);
Console.WriteLine(display);