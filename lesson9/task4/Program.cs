Console.Clear();
Console.Write("Enter number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int FindSquare(int numberA, int numberB){
    if(numberB == 1) return numberA;
    return numberA*FindSquare(numberA, --numberB);
}

Console.WriteLine(FindSquare(numberA, numberB));