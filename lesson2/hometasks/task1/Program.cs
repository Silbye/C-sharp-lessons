void findSecondDigit()
{
    Console.Clear();

    Console.Write("Enter your Number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int secondDigit = 0;

    if (number > 100 & number < 1000)
    {
        secondDigit = number % 100;
        secondDigit/=10;
        Console.WriteLine("The second digit of your number is - " + secondDigit);
    }
    else
    {
        Console.WriteLine("Your number does NOT consist of 3 digits");
    }
}
findSecondDigit();