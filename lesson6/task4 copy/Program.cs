Console.Clear();

void PrintArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 31);
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[,] array = new int[4, 4];
PrintArray(array);

Console.WriteLine();

void CopyArray(int[,] arrayCopy){
    for(int i = 0; i<arrayCopy.GetLength(0); i++){
        for(int j = 0; j<arrayCopy.GetLength(1); j++){
            arrayCopy[i, j] = array[i, j];
            Console.Write($"{arrayCopy[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] arrayCopy = new int[4, 4];
CopyArray(arrayCopy);