int getMaxNumberRandomValue(){
    int randomValue = new Random().Next(10, 100);

    Console.WriteLine("The number is - " + randomValue);

    int firstNumber = randomValue / 10;
    int secondNumber = randomValue % 10;

    int maxNumber = 0;
    
    if (firstNumber == secondNumber)
    {
        Console.WriteLine("The numbers are equal");
    }
    else
    {
        if (firstNumber > secondNumber)
        {
            maxNumber = firstNumber;
        }
        else
        {
            maxNumber = secondNumber;
        }
        Console.WriteLine("Max = " + maxNumber);
    }
    return maxNumber;
}

int numbrer = getMaxNumberRandomValue();
Console.WriteLine(numbrer);








