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

Dictionary<int, int> numbers = new Dictionary<int, int>();
for (int i = 0; i < array.GetLength(0); i++){
    for(int j = 0; j<array.GetLength(1); j++){
        int number = array[i,j];
        if (numbers.ContainsKey(number))
           numbers[number]++;
        else
           numbers[number] = 1;
    }
}
foreach (var pair in numbers)
    Console.WriteLine($"Number {pair.Key} was found {pair.Value} times");