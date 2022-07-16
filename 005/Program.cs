//Задача № 5
//С клавиатуры вводятся три числа. 
//Найти максимальное из трех чисел
/*
int a;b;c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
m=a;
if(a>b)
{
   
}
System.Console.WriteLine(Max);
*/

/*
int i=2;
int N=3;
int a;b;c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
int Max=a;
i=1;

if(i<N)
{
    if
    (numbers[i]>Max)
    (Max=numbers[i]);
    else
    i=i+1;
}
System.Console.WriteLine(Max);
*/
// Классический подход
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result) result = arg2;
    if(arg3> result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39653;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 2334;
int c3 = 33;

//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max (max1, max2,max3);
int max = Max(
    Max(a1,b1,c1),
    Max(a2,b2,c2),
    Max(a3,b3,c3));
System.Console.WriteLine(max);
*/
/*
//Решение при помощи функциию. Максимальное из трех чисел
int Max(int arg1, int arg2, int arg3);
{
    int result = arg1
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result;
}
*/
/*
// РЕШЕНИЕ ПРИ ПОМОЩИ МАССИВА
int Max (int a, int b, int c);
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
    int result = arg1;
    if(b> result) result = b;
    if(c> result) result = c;
    return result;
//   index     0  1  2  3  4  5  6  7  8 
int[] array = new array [8];
//array[0] = 12;
//System.Console.WriteLine(array[4]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(max);
*/

// РЕШЕНИЕ
int a,b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);
int m = a;
if(b>a)
{
   m = b; 
}
else
{
    if(c>a)
    m=c;
}
System.Console.WriteLine(m);