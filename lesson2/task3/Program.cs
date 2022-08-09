void multiple()
{
    Console.Clear();

    Console.Write("Enter Number 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Number 1: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    int remainder = number1 % number2;

    if(remainder == 0)
    {
        Console.WriteLine("Number 1 is multiple of Number 2");
    }
    else
    {
        Console.WriteLine("Number 1 is not multiple of Number 2, and the remainder is - " + remainder);
    }
}
multiple();