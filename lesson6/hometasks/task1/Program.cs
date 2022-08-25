Console.Clear();
Console.Write("Enter your numbers (use a space to divide numbers): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int FindPositiveNumbersAmount(int[] array){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] > 0)
        {
            count++;
        }        
    }
    return count;
}

int display = FindPositiveNumbersAmount(array);
Console.WriteLine("Positive numbers amount: " + display);