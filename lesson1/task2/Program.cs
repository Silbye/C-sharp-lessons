Console.Write("Enter week day: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 6)
{
    Console.WriteLine("There is no such week day!");
}

switch(number){
    case 0:
    Console.WriteLine("Today is Monday");
    break;
    case 1:
    Console.WriteLine("Today is Tuesday");
    break;
    case 2:
    Console.WriteLine("Today is Wednesday");
    break;
    case 3:
    Console.WriteLine("Today is Thursday");
    break;
    case 4:
    Console.WriteLine("Today is Friday");
    break;
    case 5:
    Console.WriteLine("Today is Saturday");
    break;
    case 6:
    Console.WriteLine("Today is Sunday");
    break;
}
