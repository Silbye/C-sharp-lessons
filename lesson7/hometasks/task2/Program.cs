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

Console.Write("Enter number you want to find: ");
int neededNumber = Convert.ToInt32(Console.ReadLine());

int[] FindNumber(int[,] array){
    int[] index = new int[2];
    bool foundNumber = false;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(array[i, j] == neededNumber){
                foundNumber = true;
                index[0] = i;
                index[1] = j;
            }
        }
    }
    if(foundNumber == true){
        return index;
    }
    else{
        throw new Exception("Couldn't find your number");
    }
}

int[] numberIndex = new int[2];
numberIndex = FindNumber(array);

void PrintFoundIndex(int[] array){
    for(int i=0; i<array.Length; i++){
        Console.Write($"{array[i]} ");
    }
}
PrintFoundIndex(numberIndex);