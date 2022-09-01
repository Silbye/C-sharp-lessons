Console.Clear();

int[] DetermineArraySize(){
    int[] size = new int[3];
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
int[,] firstArray = new int[size[0], size[1]];
int[,] secondArray = new int[size[1], size[2]];
int[,] finalArray = new int[size[0], size[2]];

CreateArray(firstArray);
CreateArray(secondArray);

PrintArray(firstArray);
Console.WriteLine();
PrintArray(secondArray);

Console.WriteLine();

int[,] MultiplyArrays(int[,] array1, int[,] array2, int[,] finalarray){
    for (int i = 0; i < finalArray.GetLength(0); i++){
        for (int j = 0; j < finalArray.GetLength(1); j++){
            int summ = 0;
            for (int k = 0; k < array1.GetLength(1); k++){
                summ += array1[i,k] * array2[k,j];
            }
            finalArray[i,j] = summ;
        }
    }
    return finalArray;
}

finalArray = MultiplyArrays(firstArray, secondArray, finalArray);
PrintArray(finalArray);