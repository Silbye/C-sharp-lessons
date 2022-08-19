Console.Clear();
int[] array = {1, 2, 3, 4, 5, 3, 4, 5, 1, 0, 7};

string FindPairs(int[] array){
    int newArrayLength = array.Length/2;
    string result = "";
    if(array.Length%2 == 1){
        newArrayLength++;
    }
    int[] newArray = new int[newArrayLength];
    int index = 0;
    int indexMin = 0;
    int indexMax = array.Length-1;
    while(indexMin<indexMax && index < newArrayLength){
        newArray[index] = array[indexMin]*array[indexMax];
        result+=newArray[index]+" ";
        index++;
        indexMin++;
        indexMax--;
    }
    if(indexMin==indexMax){
        newArray[index]=array[indexMin];
        result+=newArray[index]+" ";
    }
    return result;
}

string display = FindPairs(array);
Console.WriteLine(display);