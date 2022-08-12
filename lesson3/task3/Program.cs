Console.Clear();
Console.Write("Enter X: ");
int xa = Convert.ToInt32(Console.ReadLine());
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());

double getDistance(int xa, int xb, int ya, int yb){
    float A = MathF.Pow((xa-ya),2);
    float B = MathF.Pow((xb-yb),2);
    double d = A+B;
    double distance = Math.Sqrt(d);
    return Math.Round(distance, 3);
}
double result = getDistance(xa, xb, ya, yb);
Console.WriteLine(result);