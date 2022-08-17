// Нолики
// В матрице найти положение первого нулевого элемента
// Входные данные как в предыдущей задаче
// Хотя бы 1 нулевой элемент в матрице существует
// Выходные данные
// Вывести сначала номер строки а затем номер столбца нулевого элемента
// Если в матрице несколько нулей выдать позицию каждого из них
// Пример:
// 3 4
// 1 3 5 6 
// 2 5 8 0 
// 4 3 1 6 
//

int N=4;
int M=4;
int[,] a;
a=new int[N,M]; // Описываем массив
// Инициализация случайными числами
Random random=new Random();

for(int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLength(1);j++)
    {
        a[i,j]=random.Next(0,2);
    }
}
// Вывод масива на экран
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLength(1);j++) System.Console.Write($"{a[i,j]} ");
        System.Console.WriteLine();

}
// Ищем нолики
bool flag = false;
for (int i=0;i<a.GetLength(0);i++)
{
    for (int j=0;j<a.GetLength(1);j++)
    {
        if (a[i,j]==0)
        {
            System.Console.Write($"{i} "+$"{j} ");
            flag=true;
            break;
        }
    }
if(flag)
{break;}
}