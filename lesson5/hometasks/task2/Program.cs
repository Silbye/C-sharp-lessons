Console.Clear();
int[] array = new int[10];

string PrintArray(int[] array){
    string result = "";
    for(int i = 0; i<array.Length; i++){
        array[i] = new Random().Next(-100, 101);
        result+=array[i]+" ";
    }
    return result;
}

int FindUnevenIndexNumberSumm(int[] array)
{
    int summ = 0;
    for(int i = 0; i<array.Length; i++){
        if(i % 2 == 1){
            summ+=array[i];
        }
    }
    return summ;
}
string display = PrintArray(array);
int display2 = FindUnevenIndexNumberSumm(array);
Console.WriteLine(display);
Console.WriteLine(display2);