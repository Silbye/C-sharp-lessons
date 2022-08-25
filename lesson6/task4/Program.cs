Console.Clear();
int[] array = new int[10];

string PrintArray(int[] array){
    string result = "";
    for(int i = 0; i<array.Length; i++){
        Console.Write("Enter your array member: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        result+=array[i]+" ";
    }
    return result;
}

string CopyArray(int[] array){
    int[] arrayCopy = new int[10];
    string result = "";
    for(int i = 0; i < arrayCopy.Length; i++){
        arrayCopy[i] = array[i];
        result+=arrayCopy[i]+" ";
    }
    return result;
}

string method1 = PrintArray(array);
string method2 = CopyArray(array);
Console.WriteLine("Your array is: " + method1);
Console.WriteLine("Your array copy is: " + method2);