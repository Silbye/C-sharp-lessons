Console.Clear();

void PrintArray(double[,] array){
    double rounded = 0;
    Random random = new Random();
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = Convert.ToDouble(random.Next(-100, 101))/Convert.ToDouble(random.Next(1, 11));
            rounded = Math.Round(array[i, j], 1);
            Console.Write($"{rounded}  ");
        }
    Console.WriteLine();
    }
}

double[,] array = new double[3, 4];
PrintArray(array);