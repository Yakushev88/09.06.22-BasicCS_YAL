// Задача №6
// Написать программу вычисления значения функции 
//y = sin(a). 
//(Класс Math)
/*
double x,y;
x=3.14;
y=Math.Sin(x);
//System.Console.WriteLine($"sin{x}={y}");
System.Console.WriteLine(y);
*/
// тип возвращаемого значения Имя_функции(аргументы функции)
double Sin(double x)// методы (функции)
{
    return Math.Sin(x);
}
double y=Sin(3.14);
System.Console.WriteLine(y);

/*
double Sum(double a, double b)
{
    return a+b;
}

void Pause()
{
    System.Console.WriteLine("Press any Key");
}
double y=Sin(3.14);
System.Console.WriteLine(y);
Pause();
 */