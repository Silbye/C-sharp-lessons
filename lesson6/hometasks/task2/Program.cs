Console.Clear();
double[] k = new double[2];
double[] b = new double[2];

void WriteVarieables(double[] k, double[] b){
    for(int i = 0; i<k.Length; i++){
        Console.Write("Enter your k array member: ");
        k[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine();
    for(int j = 0; j<b.Length; j++){
        Console.Write("Enter your b array member: ");
        b[j] = Convert.ToDouble(Console.ReadLine());
    }
}

WriteVarieables(k,b);

string FindPoint(double[] k, double[] b){
    double x = -(b[0]-b[1])/(k[0]-k[1]);
    double y = k[0]*x+b[0];
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    string result = $"{x}; {y}";
    return result;
}

string display = FindPoint(k, b);
Console.WriteLine(display);