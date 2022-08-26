Console.Clear();

void PrintArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] array = new int[3, 4];
PrintArray(array);

int FindDiagonalSumm(int[,] array){
    int summ = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(i==j){
                summ+=array[i, j];
            }
        }
    }
    return summ;
}

int display = FindDiagonalSumm(array);
Console.WriteLine(display);