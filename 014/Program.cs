// Задача №14
//С клавиатуры вводятся два числа a и b. Выяснить, 
//кратно ли число a числу b, если нет, 
//вывести остаток от деления a на b.
int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
int h=a%b;
if (a%b==0) 
    {
    System.Console.Write("Число a кратно числу b"); 
    }
else
    {
    System.Console.WriteLine(h);
    }
    