Console.Clear();
Console.Write("Enter your Quarter: ");
int quarter = Convert.ToInt32(Console.ReadLine());
string result = findGraph(quarter);
Console.WriteLine(result);

string findGraph(int quarter)
{
    if (quarter == 1)
    {
        return "x > 0, y > 0";
    }
    if (quarter == 2)
    {
        return "x < 0, y > 0";
    }    
    if (quarter == 3)
    {
        return "x < 0, y < 0";
    }  
    if (quarter == 4)
    {
        return "x > 0, y < 0";
    }  
    throw new Exception("There is no such Quarter");
}
