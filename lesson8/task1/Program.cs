Console.Clear();

int[] DetermineArraySize(){
    int[] size = new int[2];
    for(int i=0; i<size.Length; i++){
        Console.WriteLine("Enter your array size: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

void PrintArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

int[] size = DetermineArraySize();
int[,] array = new int[size[0], size[1]];
PrintArray(array);
Console.WriteLine();

int[,] SwapRows(int[,] array){
    int temporaryValue = 0;
    int row = array.GetLength(0);
    for(int i = 0; i<array.GetLength(1); i++){
        temporaryValue = array[0, i];
        array[0,i] = array[row-1, i];
        array[row-1, i] = temporaryValue;
    }
    return array;
}

int[,] display = SwapRows(array);

void PrintChangedArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
PrintChangedArray(display);