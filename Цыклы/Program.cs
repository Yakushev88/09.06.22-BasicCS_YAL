// 

/*
int i = 0;
int N=10;
while(i<N)// цикл "пока". Универсальный цикл
{
    i++;
    System.Console.Write($"{i} ");
}
*/
// Цикл for (Для)
int i=0;
int N=10;
for(i=0;i<N;i=i+1)
{
    System.Console.Write($"{i} ");
}

// do оператор делай, пока НЕ
int a;
do
{
    System.Console.WriteLine("Введите положительное число ");
    int a=Convert.ToInt32(console.Readline()); // то что введем в строке запроса инфоромации
    // преобразуется в другой тип данных в целое число.
}
while(a<=0);

