﻿Console.Write("Enter number 1: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2: ");

int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 3: ");

int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > max)
{
    max = number2;
    if(number3>max)
    {
        max = number3;
    }
    Console.Write("Max number is " + max);
}
else
{
    if(number3>max)
    {
        max = number3;
        Console.Write("Max number is " + max);
    }
    Console.Write("Max number is " + max);
}
