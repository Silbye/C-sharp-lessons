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

int[,] RemoveRowAndCollumn(int[,] array){
    int min = array[0, 0];
    int mini = 0;
    int minj = 0;
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 1; j<array.GetLength(1); j++){
            if(array[i,j] < min){
                min=array[i,j];
                mini = i;
                minj = j;
                Console.Write($"{i}; {j}");
                Console.WriteLine();
            }
        }
    }
    Console.WriteLine();
    int[,] newArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
    int inew = 0;
    int jnew = 0;
    for(int i = 0; i<newArray.GetLength(0); i++){
        for(int j = 0; j<newArray.GetLength(1); j++){
            if (i<mini){
                newArray[inew, j] = array[i,j];
            }
            if (i>mini){
                newArray[inew, j] = array[i+1,j];
            }
            if (j<minj){
                newArray[i, jnew] = array[i,j];
            }
            if (j>minj){
                newArray[i, jnew] = array[i,j+1];
            }
            inew++;
            jnew++;
        }
    }
    return newArray;
}

int[,] newArray = RemoveRowAndCollumn(array);
PrintArray(newArray);