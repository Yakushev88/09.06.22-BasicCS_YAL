// Максимальная строка
// В матрице найти номер строки, 
// сумма чисел в которой максимальна
// Строка которая конвертирует написанное в строке
string s=Console.ReadLine();
// в числовой формат, забирая нулевой элемент 
int N=int.Parse(s.Split(' ')[0]);
int M=int.Parse(s.Split(' ')[1]);
int[,] a=new int[N,M];
for (int i=0;i<N;i++)
{
    s=Console.ReadLine();
    string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
    for(int j=0;j<ss.Length; j++)
        a[i,j]=int.Parse(ss[j]);
}
Print(a);
Solution2 (a);

// Вывод на экран
void Print(int[,] a)
{
    for (int i=0;i<a.GetLength(0);i++)
    {   // F2- ТОЛЬКО два знака после запятой
        for (int j=0;j<a.GetLongLength(1);j++) System.Console.Write($"{a[i,j],4} ");
        System.Console.WriteLine();
    }
}

// Подпрограмма решения для нахождения строки
// с максимальной суммы
/*
void Solution (int[,] a)
{
    int max=0;
    for (int i=0;i<a.GetLongLength(0); i++)
    {
        int sum=0;
        for (int j=0; j<a.GetLength(1); j++)
            sum=sum+a[i,j];
        if (sum>max)
            max=sum;
    }
    System.Console.WriteLine(max);
}
*/
// Находжнеие НОМЕРА максимальной строки

void Solution2 (int[,] a)
{
    int max=0;
    int imax =0;
    for (int i=0;i<a.GetLongLength(0); i++)
    {
        int sum=0;
        for (int j=0; j<a.GetLength(1); j++)
            sum=sum+a[i,j];
        if (sum>max)
        {
            max=sum;
            imax=i;
        }
    }
    System.Console.WriteLine(imax);
}