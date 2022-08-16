Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int Count = 1;

string getFactorial(int N){
    string result = "";
    for(int i=1;i<=N;i++){
        Count=Count*i;
        result=result+Count+", ";
    }
    return result;
}

string display = getFactorial(N);
Console.WriteLine(display);
