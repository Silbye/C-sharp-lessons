Console.Clear();
Console.Write("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void PrintNumbersUntillNumber(int numberM, int numberN){
    if (numberM > numberN) return;
    Console.Write(numberM+" ");
    numberM++;
    PrintNumbersUntillNumber(numberM, numberN);
}
PrintNumbersUntillNumber(numberM, numberN);