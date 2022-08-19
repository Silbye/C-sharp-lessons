Console.Clear();
int[] array = new int[123];

string PrintArray(int[] array){
    string result = "";
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(1, 124);
        result+=array[i]+" ";
    }
    return result;
}

int FindNumberInRangeAmount(int[] array)
{
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        if(array[i] >= 10 && array[i] <= 99){
          count++;
        }
    }
    return count;
}
string display = PrintArray(array);
int display2 = FindNumberInRangeAmount(array);
Console.WriteLine(display);
Console.WriteLine(display2);
