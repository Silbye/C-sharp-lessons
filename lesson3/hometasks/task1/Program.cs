Console.Clear();
Console.Write("Enter your number: ");
string Number = Console.ReadLine();

bool checkPalindrom(string Number){
    if(Number.Reverse().SequenceEqual(Number)){
        return true;
    }
    else{
        return false;
    }
}

bool display = checkPalindrom(Number);
Console.WriteLine(display);