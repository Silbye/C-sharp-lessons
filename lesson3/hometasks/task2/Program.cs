Console.Clear();
Console.Write("Enter X: ");
int xa = Convert.ToInt32(Console.ReadLine());
int xb = Convert.ToInt32(Console.ReadLine());
int xc = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
int yb = Convert.ToInt32(Console.ReadLine());
int yc = Convert.ToInt32(Console.ReadLine());

double getDistance(int xa, int xb, int ya, int yb, int yc, int xc){
    double A = Math.Pow((xa-ya),2);
    double B = Math.Pow((xb-yb),2);
    double C = Math.Pow((xc-yc),2);
    double d = A+B+C;
    double distance = Math.Sqrt(d);
    return Math.Round(distance, 2);
}
double result = getDistance(xa, xb, ya, yb, xc, yc);
Console.WriteLine(result);