Console.Write("Enter your number: ");

int n = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (number <= n){
    if(number % 2 == 0)
    {
        Console.Write(number);
        Console.Write(", ");
    }
    number++;
}