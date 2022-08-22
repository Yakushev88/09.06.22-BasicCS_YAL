/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить столбец с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждом столбце и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] matrix = {{3,4,5},
                {2,3,4},
                {7,4,2},
                {2,3,7}};
 
int sum = 0;
 
int index = 0;
 
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = 0;
 
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        temp += matrix[j, i];
    }
    if (temp > sum)
    {
        sum = temp;
 
        index = i;
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    Console.WriteLine(matrix[i, index]);
}
