Console.Clear();

Console.Write("Enter your Number: ");
int number = Convert.ToInt32(Console.ReadLine());

int findThirdDigit(int number)
{
    if (number >= 100)
    {
        while (number >= 1000)
        {
            number /= 10;
        }
        int thirdDigit = number % 10 % 10;
        return thirdDigit;
    }
    throw new Exception("Number must have at least 3 digits");
}

int display = findThirdDigit(number);
Console.WriteLine(display);