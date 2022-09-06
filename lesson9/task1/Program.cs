Console.Clear();
Console.Write("Write your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int currentNumber = 0;

void PrintNumbersUntillNumber(int number){
    if (number != 0){
        if (currentNumber == 0) currentNumber++;
    }
    if (currentNumber > number) return;
    Console.Write(currentNumber+" ");
    currentNumber++;
    PrintNumbersUntillNumber(number);
}
PrintNumbersUntillNumber(number);