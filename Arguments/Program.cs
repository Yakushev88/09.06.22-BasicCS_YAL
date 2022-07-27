// Алгоритм замены переменных
// Замена переменных без использования 
//третьей переменной
/*
int a,b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
// Как обычно делают
//a=b;
//b=a;
// Как можно сделать
a=a+b;
b=a-b;
a=a-b;
System.Console.WriteLine($"{a} {b}");
*/

//Замена с использованием переменной
/*
int a,b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
int t=a;
a=b;
b=t;
Console.WriteLine($"{a} {b}");
*/
/*
// Подпрограмма
void Swap(int a, int b) //Создали подпрограмму
{
    int t=a;
    a=b;
    b=t;  
}
int a,b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
Swap(a,b); // Обратились к подпрограмме
Console.WriteLine($"{a} {b}");
*/
// Подпрограмма
// При создании переменных в подпрограмме, но в а и в 
// поместиться адрес переменных таких же.
// модификатор ref- позволяет написать подпрограммы для изменния(замены) значений переменных.
void Swap(ref int a, ref int b) //Создали подпрограмму
{
    int t=a;
    a=b;
    b=t;  
}

void Calc(int a, int b, ref int sum, ref int sub)
{
    sum=a+b;
    sub=a-b;
}
int a,b,sum=0,sub=0;
a=1;
b=2;
Calc(a,b,ref sum,ref sub);
/*
System.Console.WriteLine($"{a} {b}");
Swap(ref a,ref b); // Обратились к подпрограмме
Console.WriteLine($"{a} {b}");
*/

// Что бы вернуть переменные, поскольку исползовали void
// причем раздых типов данных (int, double и проче)
// используем команду - OUT
void Swap(ref int a, ref int b) //Создали подпрограмму
{
    int t=a;
    a=b;
    b=t;  
}
// OUT ДЛЯ ВЫВОДА
void Calc(int a, int b, out int sum, out int sub)
{
    sum=a+b;
    sub=a-b;
}
int a,b,sum=0,sub=0;
a=1;
b=2;
Calc(a,b,out sum,out sub);