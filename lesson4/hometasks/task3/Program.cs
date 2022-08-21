Console.Clear();
int[] array = new int[8];

string WriteArray(int[] array){
    
    Console.WriteLine("Enter your array numbers: ");
    string result = "";
    for(int i = 0; i < array.Length; i++){
        array[i] = int.Parse(Console.ReadLine());
        result += array[i]+" ";
    }
    return result;
}
string display = WriteArray(array);
Console.WriteLine(display);