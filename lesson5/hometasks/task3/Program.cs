Console.Clear();
double[] array = new double[10];

string PrintArray(double[] array){
    string result = "";
    double rounded = 0;
    Random random = new Random();
    for(int i = 0; i<array.Length; i++){
        array[i] = Convert.ToDouble(random.Next(-100, 101))/Convert.ToDouble(random.Next(1, 11));
        rounded = Math.Round(array[i], 2);
        result+=rounded+"     ";
    }
    return result;
}

double FindMinMaxDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    double diff;
    for(int i = 1; i<array.Length; i++){
        if(array[i]<min){
            min = array[i];
        }
        if(array[i]>max){
            max = array[i];
        }
    }
    diff = max - min;
    return Math.Round(diff, 2);
}
string display = PrintArray(array);
double display2 = FindMinMaxDifference(array);
Console.WriteLine(display);
Console.WriteLine(display2);