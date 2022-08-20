// Задача №29
// Подсчитать сумму цифр в числе

int x = int.Parse(Console.ReadLine());
int sum=0;
for (int i=3; i>=0; i--)
{
    sum+=x/(int)Math.Pow(10.0,i);
    x=x%(int)Math.Pow(10.0,i);
}
Console.WriteLine(sum);

/*
// Подпрограмма для посчета цыфр в числе

int СчетчикЦыфр(int N) // подпрограма
{
    int k=0;
    int sum = 0;
 while (N!=0)
{
    k=k+1;
    N=N/10;
}
return k;


 }
 System.Console.WriteLine(СчетчикЦыфр(1876));
*/