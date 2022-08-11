void findMultiple()
{
    Console.Clear();

    Console.Write("Enter your Number: ");
    int number = Convert.ToInt32(Console.ReadLine());

    if(number % 7 == 0 & number % 23 == 0){
        Console.WriteLine("Your number IS a multiple of both 7 and 23");
    }
    else{
        Console.WriteLine("Your number IS NOT a multiple of both 7 and 23");
    }
}
void findSquare()
{
    Console.Write("Enter Number 1: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter Number 2: ");
    int number2 = Convert.ToInt32(Console.ReadLine());

    if(number1 / number2 == number2){
        Console.WriteLine("Number 1 is square of Number 2");
    }
    else{
        if(number2 / number1 == number1){
            Console.WriteLine("Number 2 is square of Number 1");
        }
        else{
            Console.WriteLine("Neither Number is a square of the other");
        }
    }
}
findMultiple();
findSquare();