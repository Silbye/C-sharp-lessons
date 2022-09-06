Console.Clear();
Console.Write("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int summ = 0;

int FindSumm(int numberM, int numberN){
    if (numberM <= numberN){
        summ+=numberM;
        numberM++;
        FindSumm(numberM, numberN);
    }
    return summ;
}
Console.WriteLine(FindSumm(numberM, numberN));