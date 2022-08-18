Console.Clear();

Console.Write("Enter your Number: ");
int number = Convert.ToInt32(Console.ReadLine());

int findDigitSumm(int number){
    int summ = 0;
    if(number >= 10){
        while(number>0){
            summ+=number%10;
            number/=10;
        }
    }
    else{
        summ = number;
    }
    return summ;
}

int display = findDigitSumm(number);
Console.WriteLine(display);