Console.Clear();

int[] DetermineArraySize(){
    int[] size = new int[2];
    for(int i=0; i<size.Length; i++){
        Console.WriteLine("Enter your array size: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

double[,] CreateArray(double[,] array){
    double rounded = 0;
    Random random = new Random();
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = Convert.ToDouble(random.Next(-100, 101))/Convert.ToDouble(random.Next(1, 11));
            rounded = Math.Round(array[i, j], 1);
            array[i,j] = rounded;
        }
    }
    return array;
}

void PrintArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]}  ");
        }
    Console.WriteLine();
    }
}

int[] size = DetermineArraySize();
double[,] array = new double[size[0], size[1]];
CreateArray(array);
PrintArray(array);