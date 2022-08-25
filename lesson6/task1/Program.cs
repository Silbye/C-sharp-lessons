Console.Clear();
Console.Write("Enter number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool CanTriangleExist(int a, int b, int c){
    bool triangle = false;
    if(a<b+c){
        if(b<a+c){
            if(c<a+b){
                triangle = true;
            }
        }
    }
    else{
        triangle = false;
    }
    return triangle;
}
bool display = CanTriangleExist(a,b,c);
if(display == true){
    Console.WriteLine("Your triangle can exist");
}
else{
    Console.WriteLine("Your triangle can not exist");
}