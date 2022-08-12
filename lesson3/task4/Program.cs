Console.Clear();
Console.Write("Enter your number: ");
int N = Convert.ToInt32(Console.ReadLine());
string result = "";

string getSquares(int N){
    for(int i=0;i<=N;i++){
        result+=Math.Pow(N, i)+", ";
    }
    //while(number <= N){
        //result+=Math.Pow(N, number)+", ";
      //  number++;
    //}
    return result;
}

string display = getSquares(N);
Console.WriteLine(display);
