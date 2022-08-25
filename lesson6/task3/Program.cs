Console.Clear();

int number0 = 0;
int number1 = 1;
int number2;
Console.Write("Enter your number: ");
int neededNumber = Convert.ToInt32(Console.ReadLine());

string Fibonacci(int n){
    string result = number0 + " " + number1 + " ";
    for(int i = 3; i <= n; i++){
        number2 = number0 + number1;
        result += number2+" ";
        number0 = number1;
        number1 = number2;
    }
    return result;
}

string display = Fibonacci(neededNumber);
Console.WriteLine(display);