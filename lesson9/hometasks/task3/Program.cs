Console.Clear();
Console.Write("Enter M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FindAckermann(int numberM, int numberN){
    if (numberM == 0) return numberN + 1;
    else{
        if((numberM != 0) && (numberN == 0)){
            return FindAckermann(numberM - 1, 1);
        }
        else return FindAckermann(numberM - 1, FindAckermann(numberM, numberN - 1));
    }
}
Console.WriteLine(FindAckermann(numberM, numberN));