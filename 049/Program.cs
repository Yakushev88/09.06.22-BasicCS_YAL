﻿// 49. Показать двумерный массив размером m×n 
//заполненный вещественными числами

int N=4;
int M = 4;
// Спарава слева от запятой указание на меры
// запятых может быть большеб мерность увеличивается 
double[,] a; // Описываем массив

a=new double[N,M];//Создаем массив
// инициализация случайными числами
Random random=new Random();// Создали объект типа рандом
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLongLength(1);j++)
    {   // для увеличения диапазона рандомных чисел
        // умножаем на 10
        a[i,j]=random.NextDouble()*10+1;
    }
}
// Вывод массива на экран
for (int i=0;i<a.GetLength(0);i++)
{   // F2- ТОЛЬКО два знака после запятой
    for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j]:F2} ");
    System.Console.WriteLine();
}

