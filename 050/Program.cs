﻿// 50. В двумерном массиве n×k заменить четные 
//элементы на противоположные
/*
int N=4;
int M = 4;
// Спарава слева от запятой указание на меры
// запятых может быть большеб мерность увеличивается 
int[,] a; // Описываем массив

a=new int[N,M];//Создаем массив
// инициализация случайными числами
Random random=new Random();// Создали объект типа рандом
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLongLength(1);j++)
    {   // для увеличения диапазона рандомных чисел
        // умножаем на 10. Прбавляя 1 смещаем от 1 до 11
        a[i,j]=random.Next(1,11);
    }
}

// Вывод массива на экран до обработки
for (int i=0;i<a.GetLength(0);i++)
{   // F2- ТОЛЬКО два знака после запятой
    for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j],4} ");
    System.Console.WriteLine();
}
// Решение
for (int i=0;i<a.GetLength(0);i++)
{   // F2- ТОЛЬКО два знака после запятой
    for (int j=0;j<a.GetLongLength(1);j++) 
        if (a[i,j]%2==0)
            a[i,j]=-a[i,j];
System.Console.WriteLine();
}
// Вывод двумерки после замены на противоположные
for (int i=0;i<a.GetLength(0);i++)
{   // F2- ТОЛЬКО два знака после запятой
    for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j],4} ");
    System.Console.WriteLine();
}
*/

// использование подпрограмм Print для вывода массива

int N=4;
int M = 4;
// Спарава слева от запятой указание на меры
// запятых может быть большеб мерность увеличивается 
int[,] a; // Описываем массив

a=new int[N,M];//Создаем массив
// инициализация случайными числами
Random random=new Random();// Создали объект типа рандом
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLongLength(1);j++)
    {   // для увеличения диапазона рандомных чисел
        // умножаем на 10. Прбавляя 1 смещаем от 1 до 11
        a[i,j]=random.Next(1,11);
    }
}
// Вывод массива на экран до обработки
Print(a);
// Решение
for (int i=0;i<a.GetLength(0);i++)
{   // F2- ТОЛЬКО два знака после запятой
    for (int j=0;j<a.GetLongLength(1);j++) 
        if (a[i,j]%2==0)
            a[i,j]=-a[i,j];
System.Console.WriteLine();
}
// Вывод двумерки после замены на противоположные
Print(a);

// Подпрограмма вывода на экран
void Print(int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {   // F2- ТОЛЬКО два знака после запятой
        for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j],4} ");
        System.Console.WriteLine();
    }
}