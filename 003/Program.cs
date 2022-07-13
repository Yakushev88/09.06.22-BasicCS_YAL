 //Задача №3
 //С клавиатуры вводятся два числа a и b. 
 //Найти максимальное из них.

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(a>b)
{
    System.Console.WriteLine(a);
}
else
{
    System.Console.WriteLine(b);
}