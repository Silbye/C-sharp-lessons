Console.Clear();
int[] array = new int[8];

string PrintArray(int[] array)
{
    int count = array.Length;
    int index = 0;
    string result = "";
    while (index < count)
    {
        array[index] = new Random().Next(0, 2);
        result+=array[index]+", ";
        index++;
    }
    return result;
}

string display = PrintArray(array);
Console.WriteLine(display);