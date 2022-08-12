Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 0;
string result = "";

string getSquares(int N){
    while(number <= N){
        result+=Math.Pow(N, number)+", ";
        number++;
    }
    return result;
}

string display = getSquares(N);
Console.WriteLine(display);
