Console.Clear();
int[] array = new int[10];

string PrintArray(int[] array){
    string result = "";
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(100, 1000);
        result+=array[i]+" ";
    }
    return result;
}

int FindEvenNumberAmount(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        if(array[i] % 2 == 0){
          count++;
        }
    }
    return count;
}
string display = PrintArray(array);
int display2 = FindEvenNumberAmount(array);
Console.WriteLine(display);
Console.WriteLine(display2);