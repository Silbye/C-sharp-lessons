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

Console.Write("Enter number you want to find: ");
int neededNumber = Convert.ToInt32(Console.ReadLine());

void FindNumber(int[,] array){
    bool numberFound = false;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(array[i, j] == neededNumber){
                numberFound = true;
                Console.Write($"{i}; {j}");
                Console.WriteLine();
            }
        }
    }
    if (numberFound == true){
        Console.WriteLine("Number found!");
    }
    if (numberFound == false){
        Console.WriteLine("Number not found!");
    }
}

FindNumber(array);