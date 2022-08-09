void removeSecondNumberValue()
{
    Console.Clear();
    int randomValue = new Random().Next(100, 1000);
    //Console.Write("Enter your number: ");
    //int randomValue = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The number is - " + randomValue);

    if (randomValue > 100 & randomValue < 1000)
    {
        int firstNumber = randomValue / 100;
        int thirdNumber = randomValue % 10;

        Console.WriteLine("First letter is - " + firstNumber);
        Console.WriteLine("Third letter is - " + thirdNumber);

        Console.WriteLine("The number without the middle letter is - " + firstNumber + thirdNumber);
    }
    else
    {
        Console.WriteLine("Your number doesn't consist of 3 letters");
    }
}
removeSecondNumberValue();