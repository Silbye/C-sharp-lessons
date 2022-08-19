Console.Clear();
int[] array = new int[4];

string PrintArrayWithMinusNumbers(int[] array)
{
    int amount = array.Length;
    string result = "";
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(-8, 9);
        result+=array[i]+" ";
    }
    return result;
}

string PrintArray(int[] array)
{
    string result = "";
    for(int i = 0; i<array.Length; i++){
        if(array[i]<0){
          array[i]=-array[i];
        }
        result+=array[i]+" ";
    }
    return result;
}

string display = PrintArrayWithMinusNumbers(array);
string display2 = PrintArray(array);
Console.WriteLine(display);
Console.WriteLine(display2);