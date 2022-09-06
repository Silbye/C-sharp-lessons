Console.Clear();
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());

int FindDigitsSumm (int number){
    if(number==0) return 0;
    return number%10+FindDigitsSumm(number/10);
}

Console.WriteLine(FindDigitsSumm(number));