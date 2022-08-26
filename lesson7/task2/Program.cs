Console.Clear();

void PrintArray(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}

double[,] array = new double[3, 4];
PrintArray(array);
Console.WriteLine();

void ChangeArrayElements(double[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(i%2!=0 & j%2!=0){
                array[i, j] = Math.Pow(array[i, j], 2);
            }
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
ChangeArrayElements(array);
