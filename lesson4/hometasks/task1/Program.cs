Console.Clear();
Console.Write("Enter number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int B = Convert.ToInt32(Console.ReadLine());

double getSquare(int A, int B){
    double result = Math.Pow(A, B);
    return result;
}

double display = getSquare(A, B);
Console.WriteLine(display);