Console.Write("Enter your number: ");

int n = Convert.ToInt32(Console.ReadLine());
int number = -n;

while (number <= n){
    Console.Write(number);
        Console.Write(", ");
        number++;
}

Console.WriteLine(" ");

for(int i=-n; i<=n; i++){
    Console.Write(i + ", ");
}