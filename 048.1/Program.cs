// 48. Показать двумерный массив размером m×n 
// заполненный целыми числами
int N=2;
int M = 3;
// Спарава слева от запятой указание на меры
// запятых может быть большеб мерность увеличивается 
int[,] a; // Описываем массив
a=new int[N,M];//Создаем массив
// инициализация случайными числами
Random random=new Random();// Создали объект типа рандом
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLongLength(1);j++)
    { 
        a[i,j]=random.Next(1,11);
    }
}
// Вывод массива на экран
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j]} ");
    System.Console.WriteLine();
}

