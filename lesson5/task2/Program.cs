Console.Clear();
int[] array = {6, 7, 19, 345, 3};
Console.Write("Enter the number you want to find: ");
int number = Convert.ToInt32(Console.ReadLine());

string PrintArray(int[] array){
    string result = "";
    for(int i = 0; i<array.Length; i++){
        result+=array[i]+" ";
    }
    return result;
}

bool FindNumberInArray(int number)
{
    string result = "";
    int count = 0;
    bool find;
    for(int i = 0; i<array.Length; i++){
        if(array[i]==number || -array[i]==number){
          count++;
        }
    }
    if(count>0){
        return true;
    }
    else{
        return false;
    }
}
string display2 = PrintArray(array);
bool display = FindNumberInArray(number);
Console.WriteLine(display2);
Console.WriteLine(display);