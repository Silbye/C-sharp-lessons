Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());

string getSquares(int N){
    string result = "";
    for(int i=1;i<=N;i++){
        result+=Math.Pow(i, 3)+", ";
    }
    return result;
}

string display = getSquares(N);
Console.WriteLine(display);