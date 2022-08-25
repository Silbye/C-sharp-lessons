Console.Clear();
int[] array = new int[10];

void PrintArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(-100, 101);
        Console.Write(array[i]+" ");
    }
}

int FindUnevenIndexNumberSumm(int[] array)
{
    int summ = 0;
    for(int i = 0; i<array.Length; i++){
        if(i % 2 != 0){
            summ+=array[i];
        }
    }
    return summ;
}
PrintArray(array);
Console.WriteLine();
int display2 = FindUnevenIndexNumberSumm(array);
Console.WriteLine(display2);