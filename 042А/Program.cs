// Задача 42A
/*
Даны две квадратных таблицы чисел. Требуется построить третью,
каждый элемент которой равен сумме элементов, стоящих на том же месте
в 1-й и 2-й таблицах.

Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,
а после нее - вторая. Элементы таблиц - числа от 0 до 100.
100>=N>=1.
*/
Random random=new Random();//Создали объект типа Random
int N=3;
int[,] a;//описываем массив
int[,] b;//описываем массив
int[,] c;//описываем массив
a=InitA(N,N);
b=InitA(N,N);

int[,] InitA(int N,int M)
{
    int[,] t;
    t=new int[N,M];//создаем массив
    for(int i=0;i<t.GetLength(0);i++)
    {
        for(int j=0;j<t.GetLength(1);j++) 
        {
            t[i,j]=random.Next(1,100);
        }
    }
    return t;
}

//Вывод массива на экран
void Print(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
    {
        for(int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j],5} ");
            System.Console.WriteLine();
    }
}
