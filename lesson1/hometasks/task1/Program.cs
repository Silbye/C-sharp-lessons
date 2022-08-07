Console.Write("Enter number 1: ");

int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter number 2: ");

int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if(number2 > number1)
{
    max = number2;
}
Console.WriteLine("Max number is " + max);