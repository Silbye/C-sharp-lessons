Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
string result = "";

string getSquares(int N){
    for(int i=1;i<=N;i++){
        result+=Math.Pow(i, 2)+", ";
    }
    //while(number <= N){
        //result+=Math.Pow(N, number)+", ";
      //  number++;
    //}
    return result;
}

string display = getSquares(N);
Console.WriteLine(display);
