Console.Clear();

int[] DetermineArraySize(){
    int[] size = new int[2];
    for(int i=0; i<size.Length; i++){
        Console.WriteLine("Enter your array size: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

void CreateArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
        }
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

int[] size = DetermineArraySize();
int[,] array = new int[size[0], size[1]];
CreateArray(array);
PrintArray(array);
Console.WriteLine();

int[,] SortArray(int[,] array){
    int[] sortedRow = new int[array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            for(int k = 0; k<sortedRow.Length; k++){
                sortedRow[k] = array[i,k];
            }
        }
        Array.Sort(sortedRow);
        Array.Reverse(sortedRow);
        for(int k = 0; k<sortedRow.Length; k++){
            array[i, k] = sortedRow[k];
        }
    }
    return array;
}

int[,] result = SortArray(array);
PrintArray(result);