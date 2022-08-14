Console.Clear();
Console.Write("Enter your number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberReverse = Number.ToString();

bool checkPalindrom(int Number, string NumberReverse)
{
    if (Number >= 10000 && Number < 100000)
    {
        if (NumberReverse.Reverse().SequenceEqual(NumberReverse))
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

bool display = checkPalindrom(Number, NumberReverse);
Console.WriteLine(display);