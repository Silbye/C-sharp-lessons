Console.Clear();

void CreateArray(int[,] array){
    int i = 0;
    int j = 0;
    for(int input = 1; input <= array.GetLength(0)*array.GetLength(1); input++){
        array[i,j] = input;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
}

void PrintArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
CreateArray(array);
PrintArray(array);
Console.WriteLine();
