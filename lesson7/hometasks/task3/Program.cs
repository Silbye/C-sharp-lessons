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
Console.WriteLine();
void FindAverage(int[,] array){
    double summ = 0;
    double average = 0;
    for(int j = 0; j<array.GetLength(1); j++){
        for(int i = 0; i<array.GetLength(0); i++){
            summ+=array[i,j];
        }
        average=summ/array.GetLength(0);
        double rounded = Math.Round(average, 1);
        Console.Write($"{rounded}  ");
        summ = 0;
    }
}

FindAverage(array);