Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());

int ConvertToBinary(int N)
{
    int a = 0;
    string binaryNumber = "";
    if (N == 2)
    {
        binaryNumber = "10";
    }
    else
    {
        while (N >= 1)
        {
            a = N % 2;
            binaryNumber += a;
            N /= 2;
        }
    }
    int newNumber = Int32.Parse(binaryNumber);
    return newNumber;
}

int display = ConvertToBinary(N);
Console.WriteLine(display);