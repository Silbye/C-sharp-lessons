Console.Clear();

Console.Write("Enter your Number: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = 0;

int findSecondDigit(int number)
{
    if (number > 100 & number < 1000)
    {
        secondDigit = (number % 100) / 10;
        return secondDigit;
    }
    throw new Exception("Number must consist of 3 digits");
}
int display = findSecondDigit(number);
Console.WriteLine(display);