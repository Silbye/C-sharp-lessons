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

int FindTotalSumm (int[,] array){
    int summ = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            summ+=array[i,j];
        }
    }
    return summ;
}

int summ = FindTotalSumm(array);

int FindSmallestSummRow (int[,] array, int minSumm){
    int summ = 0;
    int minimalSumm = minSumm;
    int minimalRow = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            summ+=array[i,j];
        }
        if(summ<minimalSumm){
            minimalSumm=summ;
            minimalRow=i;
        }
        summ = 0;
    }
    return minimalRow;
}

int result = FindSmallestSummRow(array, summ);
Console.WriteLine("Minimal summ row is: " + result);