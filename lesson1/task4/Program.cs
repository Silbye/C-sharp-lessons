Console.Write("Enter your number: ");

int n = Convert.ToInt32(Console.ReadLine());
int finalLetter = n%10;

if (n > 100 & n < 1000)
{
    Console.WriteLine("Final letter of your number is " + finalLetter);
}
else
{
    Console.WriteLine("Your number doesn't consist of 3 letters");
}