// 42. Выяснить являются ли три 
//числа сторонами треугольника
// bool - true or false

double a=6,b=12,c=7;
System.Console.WriteLine(IsTreangle(a,b,c));



bool IsTreangle(double a, double b, double c)
{
    // Правило математики, что сумма любых сторон 
    // больше третьей
    return(a+b>c && b+c>a && a+c>b);
}
