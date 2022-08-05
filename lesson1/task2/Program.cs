Console.Write("Enter week day: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("Today is Monday");
}
if (number == 1)
{
    Console.WriteLine("Today is Tuesday");
}
if (number == 2)
{
    Console.WriteLine("Today is Wednesday");
}
if (number == 3)
{
    Console.WriteLine("Today is Thursday");
}
if (number == 4)
{
    Console.WriteLine("Today is Friday");
}
if (number == 5)
{
    Console.WriteLine("Today is Saturday");
}
if (number == 6)
{
    Console.WriteLine("Today is Sunday");
}
if (number > 6)
{
    Console.WriteLine("There is no such week day!");
}