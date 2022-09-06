Console.Clear();

int[] DetermineArraySize(){
    int[] size = new int[3];
    for(int i=0; i<size.Length; i++){
        Console.WriteLine("Enter your array size: ");
        size[i] = Convert.ToInt32(Console.ReadLine());
    }
    return size;
}

Random random = new Random();

void CheckIfUniquePossible(int[] size){
    int uniqueNeeded = 1;
    for(int i=0; i<size.Length; i++){
        uniqueNeeded*=size[i];
    }
    if((100-10)<uniqueNeeded){
        throw new Exception("Impossible to generate this many unique 2 digit numbers");
    }
}

int GenerateUniqueNumber(int[,,] array){
    while(true){
        int number = random.Next(10, 100);
        int count = 0;
        for(int i = 0; i<array.GetLength(0); i++){
            for(int j = 0; j<array.GetLength(1); j++){
                for(int k = 0; k<array.GetLength(2); k++){
                    if(array[i, j, k] == number){
                        count++;
                    }
                }
            }
        }
        if(count == 0){
            return number;
        }
    }
}

void CreateArray(int[,,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            for(int k = 0; k<array.GetLength(2); k++){
                array[i, j, k] = GenerateUniqueNumber(array);
            }
        }
    }
}

void PrintArray(int[,,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            for(int k = 0; k<array.GetLength(2); k++){
                Console.Write($"X({i}) Y({j}) Z({k})={array[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] size = DetermineArraySize();
int[,,] array = new int[size[0], size[1], size[2]];

CheckIfUniquePossible(size);
CreateArray(array);
PrintArray(array);