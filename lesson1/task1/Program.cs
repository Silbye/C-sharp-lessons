Console.Write("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number 1 is " + number1);

Console.Write("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number 2 is " + number2);

int square = number1 * number1;
Console.WriteLine("Number 1's square is " + square);
if (square == number2)
{
    Console.WriteLine(number2 + " is " + number1 + "'s square");
}
else
{
    Console.WriteLine(number2 + " is NOT " + number1 + "'s square");
}