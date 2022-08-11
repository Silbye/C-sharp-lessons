void findThirdDigit()
{
    Console.Clear();

    Console.Write("Enter your Number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    string thirdDigit = number.ToString();

    if (number >= 100)
    {
        Console.WriteLine("The third digit of your number is - " + thirdDigit[2]);
    }
    else
    {
        Console.WriteLine("Your number does NOT have at least 3 digits");
    }
}
findThirdDigit();