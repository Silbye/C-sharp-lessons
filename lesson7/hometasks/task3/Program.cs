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

double[] FindAverage(int[,] array){
    double summ = 0;
    double average = 0;
    double[] averageArray = new double[array.GetLength(1)];
    for(int j = 0; j<array.GetLength(1); j++){
        for(int i = 0; i<array.GetLength(0); i++){
            summ+=array[i,j];
            
        }
        average=summ/array.GetLength(0);
        double rounded = Math.Round(average, 1);
        averageArray[j] = rounded;
        summ = 0;
    }
    return averageArray;
}

double[] averageArray = FindAverage(array);
void PrintAverageOfRows(double[] array){
    for(int i = 0; i<array.Length; i++){
        Console.Write($"{array[i]}  ");
    }
}
PrintAverageOfRows(averageArray);