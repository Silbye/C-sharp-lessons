Console.Clear();
Console.Write("Enter k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

string FindPoint(double k1, double k2, double b1, double b2){
    double x = -(b1-b2)/(k1-k2);
    double y = k1*x+b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    string result = $"{x}; {y}";
    return result;
}

string display = FindPoint(k1, k2, b1, b2);
Console.WriteLine(display);